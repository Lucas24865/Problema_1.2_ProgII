using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_p_1._2
{
    internal class Articulo
    {
        private int id;
        private string nombre;
        private int precioUnitario;

        public DateTime fechaBaja { get; set; }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; } 
        }
        public int PrecioUnitario
        {
            get { return precioUnitario;}
            set { precioUnitario = value; }
        }

        public Articulo()
        {
            id = -1;
            precioUnitario = 0;
            nombre = "";
        }

        public Articulo(int id,string name, int precio)
        {
            this.id = id;
            this.nombre = name;  
            this.precioUnitario = precio;
        }

    }
}
