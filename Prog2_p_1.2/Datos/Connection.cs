using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prog2_p_1._2
{
    internal class Connection
    {
        private static Connection connection;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = localhost; Initial Catalog = Facturacion_P1.2; Integrated Security = True");
        SqlCommand sqlCommand = new SqlCommand();

        private Connection()
        { }

        public static Connection GetConnection()
        {
            if (connection == null)
            { 
                connection = new Connection();
            }

            return connection;
        }

        private void Abrir()
        { 
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
        }

        private void Cerrar()
        { 
            sqlConnection.Close();
        }

        public List<Articulo> Articulos()
        { 
            DataTable dt = new DataTable();
            List<Articulo> arts = new List<Articulo>();
            sqlCommand.CommandText = "sp_Articulos";
            Abrir();
            SqlDataReader reader = sqlCommand.ExecuteReader();            
            while (reader.Read())
            {
                Articulo art = new Articulo();
                art.ID = Convert.ToInt32(reader["ID"].ToString());
                art.Nombre = reader["Nombre"].ToString();
                art.PrecioUnitario = Convert.ToInt32(reader["Precio Unitario"].ToString());
                if(!string.IsNullOrEmpty(reader["Fecha Baja"].ToString()))
                art.fechaBaja = Convert.ToDateTime(reader["Fecha Baja"].ToString());
                arts.Add(art);
            }
            Cerrar();
            return arts;
        }

        public List<DetalleFactura> DetallesFactura(int id)
        {
            List<DetalleFactura> dets = new List<DetalleFactura>();
            sqlCommand.CommandText = "sp_DetallesFactura";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nroFact", SqlDbType.Int).Value = id;
            Abrir();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
                {
                DetalleFactura det = new DetalleFactura();
                Articulo art = new Articulo();
                art.Nombre = reader["Articulo"].ToString();
                art.ID = Convert.ToInt32(reader["ID Articulo"].ToString());
                det.Cant = Convert.ToInt32(reader["Cantidad"].ToString());
                art.PrecioUnitario = Convert.ToInt32(reader["Subtotal"].ToString())/det.Cant;
                det.Art = art;
                dets.Add(det);
            }
            Cerrar();
            return dets;
        }

        private void Aniadir(int nroFact, int id_art, int cant)
        {
            sqlCommand.CommandText = "sp_AddArt";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nroFact", SqlDbType.Int).Value = nroFact;
            sqlCommand.Parameters.AddWithValue("@id_art", SqlDbType.Int).Value = id_art;
            sqlCommand.Parameters.AddWithValue("@cant", SqlDbType.Int).Value = cant;
            Abrir();
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }
        public void Quitar(int id_art)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "sp_RemoveArt";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_art", SqlDbType.Int).Value = id_art;
            Abrir();
            command.ExecuteNonQuery();
            Cerrar();
        }
        public DataTable ConsultarDB(string sp)
        {
            DataTable dt = new DataTable();
            sqlCommand.CommandText = sp;
            sqlCommand.Parameters.Clear();
            Abrir();
            dt.Load(sqlCommand.ExecuteReader());
            Cerrar();
            return dt;
        }

        public bool NuevoArt(string nombre, int precio)
        {
            Abrir();
            SqlTransaction sqlTran = sqlConnection.BeginTransaction();
            sqlCommand.Transaction = sqlTran;
            try
            {
                sqlCommand.CommandText = "sp_NewArt";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = nombre;
                sqlCommand.Parameters.AddWithValue("@price", SqlDbType.Int).Value = precio;
                sqlCommand.ExecuteNonQuery();
                sqlTran.Commit();
                Cerrar();
                return true;
            }
            catch
            {
                sqlTran.Rollback();
                Cerrar();
                return false;
            }
        }
        public void NuevoDetalle(Factura factura,DetalleFactura detalle)
        {
            sqlCommand.CommandText = "sp_AddArt";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nroFact", SqlDbType.Int).Value = factura.NroFactura;
            sqlCommand.Parameters.AddWithValue("@id_art", SqlDbType.Int).Value = detalle.Art.ID;
            sqlCommand.Parameters.AddWithValue("@cant", SqlDbType.Int).Value = detalle.Cant;
            sqlCommand.ExecuteNonQuery();

        }
        public Factura NuevaFactura(FormaPago formPago, Cliente cliente)
        {
            Factura factura = new Factura();

            sqlCommand.CommandText = "sp_NewFact";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@formPago", SqlDbType.Int).Value = formPago.ID;
            sqlCommand.Parameters.AddWithValue("@id_cliente", SqlDbType.Int).Value = cliente.ID;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Direction = ParameterDirection.Output;

            sqlCommand.ExecuteNonQuery();

            factura.NroFactura = Convert.ToInt32(sqlCommand.Parameters["@id"].Value);
            factura.Fecha = Convert.ToDateTime(sqlCommand.Parameters["@date"].Value);
            factura.ID_FPago = formPago.ID;
            factura.ID_cliente = cliente.ID;

            return factura;
        }
        public void CargarFactura(Cliente cliente,FormaPago formaPago, List<DetalleFactura> det)
        {
            Abrir();
            SqlTransaction sqlTran = sqlConnection.BeginTransaction();
            sqlCommand.Transaction = sqlTran;
            sqlCommand.CommandText = "";
            try
            {
                Factura factura = new Factura();
                factura = NuevaFactura(formaPago,cliente);
                factura.Detalles = det;
                foreach (DetalleFactura detalleFactura in det)
                {
                    NuevoDetalle(factura,detalleFactura);
                }
                sqlTran.Commit();
                System.Windows.Forms.MessageBox.Show("Se cargó exitosamente");
            }
            catch
            {
                sqlTran.Rollback();
                System.Windows.Forms.MessageBox.Show("Falló la carga");
            }     
            finally
            {
                if(sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                Cerrar();
            }
        }
    }
}
