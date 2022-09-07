using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_p_1._2
{
    internal class Factura
    {
        private int nroFactura;
        private DateTime fecha;
        private int id_fPago;
        private int id_cliente;
        private List<DetalleFactura> detalles;

        public int NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }
        public DateTime Fecha
        { 
            get { return fecha; } 
            set { fecha = value; } 
        }
        public int ID_FPago
        {
            get { return id_fPago; }
            set { id_fPago = value; }
        }
        public int ID_cliente
        { 
            get { return id_cliente; } 
            set { id_cliente = value; } 
        }
        public List<DetalleFactura> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        public void Add(DetalleFactura det)
        {
            detalles.Add(det);
        }
    }
}
