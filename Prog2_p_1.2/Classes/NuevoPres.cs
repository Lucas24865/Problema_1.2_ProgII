using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_p_1._2
{
    public partial class NuevoPres : Form
    {
        Connection con = Connection.GetConnection();
        List<Articulo> arts = new List<Articulo>();
        List<DetalleFactura> artsAniadidos = new List<DetalleFactura>();

        public NuevoPres()
        {
            InitializeComponent();
            CargarArticulos();
            lbl_Total.Text = "0";
            CargarCombo();
        }

        private void dgv_arts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarArticulos()
        {
            arts = con.Articulos();
            dgv_arts.DataSource = arts;
        }

        private void ActualizarTotal()
        {
            int sum = 0;
            for (int i = 0; i < dgv_artsAniadidos.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_artsAniadidos.Rows[i].Cells["subtotal"].Value);
            }
            lbl_Total.Text = sum.ToString();
        }
        private void CargarCombo()
        {
            cb_FormaPago.DataSource = con.ConsultarDB("sp_FormasPago");
            cb_FormaPago.DisplayMember = "string";
            cb_FormaPago.ValueMember = "ID";
            cb_Cliente.DataSource = con.ConsultarDB("sp_Clientes");
            cb_Cliente.DisplayMember = "string";
            cb_Cliente.ValueMember = "ID";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int selected = artsAniadidos.FindIndex(a => a.Art == arts[dgv_arts.CurrentCell.RowIndex]);
            if (selected == -1)
            {
                DetalleFactura dt = new DetalleFactura();
                dt.Art = arts[dgv_arts.CurrentCell.RowIndex];
                dt.Cant = Convert.ToInt32(numericQuantity.Value.ToString());
                artsAniadidos.Add(dt);
                dgv_artsAniadidos.Rows.Add(dt.Art.ID, dt.Art.Nombre, dt.Art.PrecioUnitario, dt.Cant, dt.Cant * dt.Art.PrecioUnitario, "Borrar");
            }
            else
            {
                artsAniadidos[selected].Cant += Convert.ToInt32(numericQuantity.Value.ToString());
                dgv_artsAniadidos.Rows[selected].Cells["cantidad"].Value = artsAniadidos[selected].Cant;
                dgv_artsAniadidos.Rows[selected].Cells["subtotal"].Value = artsAniadidos[selected].Cant * artsAniadidos[selected].Art.PrecioUnitario;
            }

            ActualizarTotal();
        }


        private void dgv_artAniadidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_artsAniadidos.CurrentCell.OwningColumn.Name == "borrar")
            {
                artsAniadidos.RemoveAt(dgv_artsAniadidos.CurrentCell.RowIndex);
                dgv_artsAniadidos.Rows.RemoveAt(dgv_artsAniadidos.CurrentCell.RowIndex);
            }
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ID = Convert.ToInt32(cb_Cliente.SelectedValue);
            FormaPago formaPago = new FormaPago();
            formaPago.ID = Convert.ToInt32(cb_FormaPago.SelectedValue);

            con.CargarFactura(cliente, formaPago, artsAniadidos);
        }

        private void cb_FormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
