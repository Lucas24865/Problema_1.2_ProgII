using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_p_1._2
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Cliente()
        {
            ID = -1;
            Nombre = "";
        }
        public Cliente(int iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }
    }
}
