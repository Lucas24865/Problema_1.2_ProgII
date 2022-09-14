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
    public partial class ConsultaPres : Form
    {
        Connection con = Connection.GetConnection();
        List<Articulo> arts = new List<Articulo>();
        public ConsultaPres()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void dgv_artAniadidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarCombo()
        {
            cb_factura.DataSource = con.ConsultarDB("sp_Facturas");
            cb_factura.DisplayMember = "string";
            cb_factura.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_factura_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void dgv_arts_aniadidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DetalleFactura det in con.DetallesFactura((int)cb_factura.SelectedValue))
            {
                dgv_arts_aniadidos.Rows.Add(det.Art.Nombre,det.Cant,det.Art.PrecioUnitario*det.Cant);
            }
        }
    }
}
