using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_p_1._2
{
    internal class DetalleFactura
    {
        private Articulo art;
        private int cant;

        public Articulo Art
        {
            get { return art; }
            set { art = value; }
        }
        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        public DetalleFactura()
        {
            art = new Articulo();
            cant = 0;
        }
        public DetalleFactura(int id,Articulo art, int cant)
        {
            this.art = art;
            this.cant = cant;
        }

    }
}
