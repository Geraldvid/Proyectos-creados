using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturar
    {
        public int Id { get; set; }
        public string Vendedor { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public string TipoFactura { get; set; }
        public string TipoPago { get; set; }
        public int IdProdu { get; set; }
        public string Descripcio { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor { get { return Precio * (decimal)Cantidad; } }
    }
}
