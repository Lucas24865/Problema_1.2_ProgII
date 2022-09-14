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
    public partial class NuevoArt : Form
    {
        public NuevoArt()
        {
            InitializeComponent();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            string nombre;
            int precio;
            nombre = txt_Nombre.Text;
            precio = Convert.ToInt32(txt_Precio.Text);

            Connection con = Connection.GetConnection();
            if (con.NuevoArt(nombre, precio))
            {
                MessageBox.Show("Se pudo agregar correctamente el articulo");
                txt_Nombre.Text = txt_Precio.Text = "";
            }
            else
                MessageBox.Show("No se pudo agregar el articulo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
