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
    public partial class ConsultaArts : Form
    {
        Connection con = Connection.GetConnection();
        List<Articulo> arts = new List<Articulo>();
        public ConsultaArts()
        {
            InitializeComponent();
            arts = con.Articulos();
            foreach(Articulo art in arts)
            {
                dgv_arts.Rows.Add(art.ID,art.Nombre,art.PrecioUnitario,"Borrar");
            }
        }

        private void dgv_arts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_arts.CurrentCell.OwningColumn.Name == "borrar")
            {
                con.Quitar(arts[dgv_arts.CurrentCell.RowIndex].ID);
                arts.RemoveAt(dgv_arts.CurrentCell.RowIndex);
                dgv_arts.Rows.RemoveAt(dgv_arts.CurrentCell.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
