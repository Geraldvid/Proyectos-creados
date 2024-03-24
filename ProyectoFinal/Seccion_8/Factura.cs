using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using MySql.Data.MySqlClient;

namespace Seccion_8
{
    public partial class Factura : UserControl
    {
        private Constructor constructor;
        public Factura()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        Login lg = new Login();

        private void Factura_Load(object sender, EventArgs e)
        {
            Txttotal.Text = Convert.ToString(constructor.TotalFactura());
        }

       


        private void BtnAsignar_Click(object sender, EventArgs e)
        {
        
            //Asignacion de la Factura
            constructor = new Constructor(TxtVendedor.Text);
            DtgvFactura.DataSource = constructor.Facturar;
           
           
        }

       
        public string tipofactura { get; set; }
        public string tipopago { get; set; }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            Facturar factura = new Facturar();
            factura.Id = Convert.ToInt32(TxtNfactu.Text);
            factura.Vendedor = TxtVendedor.Text;
            factura.Fecha = DtFecha.Text;
            factura.Cliente = TxtCliente.Text;
            factura.TipoFactura = tipofactura;
            factura.TipoPago = tipopago;
            factura.IdProdu = Convert.ToInt32(Txtid.Text);
            factura.Descripcio = TxtDescripcion.Text;
            factura.Precio = Convert.ToDecimal(TxtPrecio.Text);
            factura.Cantidad = Convert.ToInt32(Txttcantidad.Text);
            

            constructor.AgregarProducto(factura);
            DtgvFactura.DataSource = null;
            DtgvFactura.DataSource = constructor.Facturar;
            //DtgvFactura.Columns[1].Visible = false;
            //DtgvFactura.Columns[2].Visible = false;
            //DtgvFactura.Columns[3].Visible = false;
            //DtgvFactura.Columns[4].Visible = false;
            //DtgvFactura.Columns[5].Visible = false;
            Txttotal.Text = Convert.ToString(constructor.TotalFactura());

        }

        private void Btncontado_Click(object sender, EventArgs e)
        {
            tipofactura = "Contado";
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            tipofactura = "Crédito";

        }

        private void Btnefectivo_Click(object sender, EventArgs e)
        {
            tipopago = "Efectivo";

        }

        private void BtnTargeta_Click(object sender, EventArgs e)
        {
            tipopago = "Targeta";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sum = 1;

            TxtVendedor.Text = Vendedorcedu.ceduven;
            TxtNfactu.Text = Convert.ToString((fn.IDFacturar()+ sum));
        }

        private void BtnEnviarCliente_Click(object sender, EventArgs e)
        {
            TxtCliente.Text = TxtCeduCliente.Text;
        }

        private void TabTablas_Click(object sender, EventArgs e)
        {
            
        }

        private void DgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtCeduCliente.Text = DgCliente.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void BtnEnviarProducto_Click(object sender, EventArgs e)
        {
            Txtid.Text = TxtIdProducto.Text;
            TxtDescripcion.Text = TxtDescriProducto.Text;
            TxtPrecio.Text = TxtPrecioProducto.Text;
        }

        private void DgProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdProducto.Text = DgProducto.CurrentRow.Cells[0].Value.ToString();
            TxtDescriProducto.Text =DgProducto.CurrentRow.Cells[1].Value.ToString();
            TxtPrecioProducto.Text = DgProducto.CurrentRow.Cells[7].Value.ToString();
        }
        
        private void Btndescuento_Click(object sender, EventArgs e)
        {
            
            decimal total, subtotal, descuento;
            total = Convert.ToInt32(Txttotal.Text);
            descuento = Convert.ToDecimal(Txtdecuento.Text);
            subtotal = (total * descuento);
            total = total - subtotal;
            Txttotal.Text = Convert.ToInt32(total).ToString();
        }

        public string NumFact, idpro, descrip, canti, preciopro,subpro,subtot;
        Facturar fact = new Facturar();
        
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            NumFact = TxtNfactu.Text;
            subtot = Convert.ToString(constructor.TotalFactura());
            subpro = Convert.ToString(fact.Valor);
            idpro = Convert.ToString(fact.IdProdu);
            descrip = Convert.ToString(fact.Descripcio);
            canti = Convert.ToString(fact.Cantidad);
            preciopro = Convert.ToString(fact.Precio);

            //Factura
            string insert = "Insert Into factura values ('" + TxtNfactu.Text + "','" + TxtVendedor.Text + "','" + DtFecha.Text + "','" + TxtCliente.Text + "','" + tipofactura + "','" + tipopago + "','" + subtot + "','" + Txtdecuento.Text + "','" + Txttotal.Text + "')";
            if (fn.Insertar(insert))
            {
                MessageBox.Show("factura agregada");

                ////Detalle de factura
                MySqlCommand agregar = new MySqlCommand("INSERT INTO detallefactura VALUES(?NumFac, ?IdPro, ?Descrip, ?Canti, ?Precio, ?Subtot)", fn.conexion);
                fn.conexion.Open();
               
                {

                    foreach (DataGridViewRow row in DtgvFactura.Rows)
                    {
                        agregar.Parameters.Clear();

                        agregar.Parameters.Add("?NumFac", MySqlDbType.Int32).Value = Convert.ToString(row.Cells[0].Value);
                        agregar.Parameters.Add("?IdPro", MySqlDbType.Int32).Value = Convert.ToString(row.Cells[6].Value);
                        agregar.Parameters.Add("?Descrip", MySqlDbType.String).Value = Convert.ToString(row.Cells[7].Value);
                        agregar.Parameters.Add("?Canti", MySqlDbType.Int32).Value = Convert.ToString(row.Cells[9].Value);
                        agregar.Parameters.Add("?Precio", MySqlDbType.Decimal).Value = Convert.ToString(row.Cells[8].Value);
                        agregar.Parameters.Add("?Subtot", MySqlDbType.Decimal).Value = Convert.ToString(row.Cells[10].Value);

                        agregar.ExecuteNonQuery();
                    }
                }

             
               
            }
            else
            {
                MessageBox.Show("Error al agregar o la factura ya esta agregado", "Error al agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
         

           
        }


        private void Btnbuscarfact_Click(object sender, EventArgs e)
        {
           
                Dgfactura.DataSource = fn.RecuperarContra("select * from factura where Numero_Factura = '" + Txtidfact.Text + "'");
                Dgdetallefact.DataSource = fn.RecuperarContra("select * from detallefactura where NumeroFactura_DetalleFactura = '" + Txtidfact.Text + "'");
          
        }
        private void GbTablaProducto_Enter(object sender, EventArgs e)
        {

        }
        private void DtgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNfactu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void TxtVendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void BtnBuscarId_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtidfact.Clear();
            TxtNfactu.Clear();
            Txtid.Clear();
            TxtVendedor.Clear();
            TxtCliente.Clear();
            TxtDescripcion.Clear();
            Txttcantidad.Clear();
            Txttotal.Clear();
            TxtDescripcion.Clear();
            TxtPrecio.Clear();
            DtgvFactura.DataSource = null;
        }

        private void Btncargar_Click(object sender, EventArgs e)
        {
            try
            {
                DgCliente.DataSource = fn.RecuperarContra("Select * from cliente");
                DgProducto.DataSource = fn.RecuperarContra("Select * from producto");
            }
            catch
            {
                MessageBox.Show("Error al mostrar las tablas");
            }
        }

        private void Btntodo_Click(object sender, EventArgs e)
        {
            Dgfactura.DataSource = fn.RecuperarContra("select * from factura");
            Dgdetallefact.DataSource = fn.RecuperarContra("select * from detallefactura");
        }
        
    }

}
