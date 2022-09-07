using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_p_1._2
{
    internal class FormaPago
    {
        private int id;
        private string nombre;

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
        
        public FormaPago()
        {
            id = -1;
            nombre = "";
        }

        public FormaPago(int id,string name)
        {
            this.id = id;
            this.nombre = name;
        }

     }
}
