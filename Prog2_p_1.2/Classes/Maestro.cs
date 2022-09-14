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
    public partial class Maestro : Form
    {
        Connection con = Connection.GetConnection();
        int id = 1;
        public Maestro()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaArts arts = new ConsultaArts();
            arts.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();

        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaPres cons = new ConsultaPres();
            cons.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoArt nvo = new NuevoArt();
            nvo.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPres nvo = new NuevoPres();
            nvo.Show();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
