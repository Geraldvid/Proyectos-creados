using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Constructor
    {
        //private int Id;
        private string Vendedor;
        //private string Fecha;
        //private string Cliente;
        private List<Facturar> facturar;


        public Constructor( string vendedor)
        {
            //this.Id = id;
            this.Vendedor = vendedor;
            //this.Fecha = fecha;
            //this.Cliente = cliente;
            this.facturar = new List<Facturar>();

        }

        public List<Facturar> Facturar
        {
            get { return facturar; }
        }

        public void AgregarProducto(Facturar factura)
        {
            facturar.Add(factura);
        }

        public decimal TotalFactura()
        {
            decimal total = 0;
            foreach (Facturar factura in facturar)
            {
                total = total + factura.Valor;
            }
            return total;
        }


    }
}
