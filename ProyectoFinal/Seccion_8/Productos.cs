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

namespace Seccion_8
{
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DgProductos.DataSource = fn.RecuperarContra("'Select * from producto = '" + Txtidbusqueda.Text);
            }
            catch
            {
                MessageBox.Show("Error al mostrar productos");
            }
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string insert = "insert into producto values('" + Txtid.Text + "','" + Txtdescripcion.Text + "', '" + Txtcantidad.Text + "','" + Txtprovee1.Text + "','" + Txtprovee2.Text + "','" + Txtpreciosiniva.Text + "','" + Cbiva.Text + "','" + Txtprecioconiva.Text + "')";
            if (fn.Insertar(insert))
            {
                MessageBox.Show("Producto agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar o el producto ya esta agregado", "Error al agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txtid.Text = DgProductos.CurrentRow.Cells[0].Value.ToString();
                Txtdescripcion.Text = DgProductos.CurrentRow.Cells[1].Value.ToString();
                Txtcantidad.Text = DgProductos.CurrentRow.Cells[2].Value.ToString();
                Txtprovee1.Text = DgProductos.CurrentRow.Cells[3].Value.ToString();
                Txtprovee2.Text = DgProductos.CurrentRow.Cells[4].Value.ToString();
                Txtpreciosiniva.Text = DgProductos.CurrentRow.Cells[5].Value.ToString();
                Cbiva.Text = DgProductos.CurrentRow.Cells[6].Value.ToString();
                Txtprecioconiva.Text = DgProductos.CurrentRow.Cells[7].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Error al mostrar productos");
            }
        }

       
        

        private void Btnbuscartodo_Click(object sender, EventArgs e)
        {
            try
            {
                DgProductos.DataSource = fn.RecuperarContra("Select * from producto");
            }
            catch
            {
                MessageBox.Show("Error al mostrar productos");
            }
        }

        private void Btnbuscarid_Click(object sender, EventArgs e)
        {
            try
            {
                DgProductos.DataSource = fn.RecuperarContra("select * from producto where Id_Producto = '" + Txtidbusqueda.Text + "'");
            }
            catch
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void Btneditar_Click_1(object sender, EventArgs e)
        {
            string modificar = "update producto set Descrip_Producto = '" + Txtdescripcion.Text + "', Cantidad_Producto = '" + Txtcantidad.Text + "', Proveedor1_Producto = '" + Txtprovee1.Text + "',Proveedor2_Producto = '" + Txtprovee2.Text + "', Precio_sin_iva_Producto = '" + Txtpreciosiniva.Text + "', Iva_Producto = '" + Cbiva.Text + "', Precio_con_iva_Producto = '" + Txtprecioconiva.Text + "' where Id_Producto = " + Txtid.Text;

            if (fn.Modificar(modificar))
            {
                MessageBox.Show("Producto Modificado");
            }
            else
            {
                MessageBox.Show("Error al Modificar Producto");

            }
        }

        private void BtnEleminar_Click_1(object sender, EventArgs e)
        {
            string eleminar = "delete from producto where Id_Producto =  " + Txtid.Text;

            if (fn.Eleminar(eleminar))
            {
                MessageBox.Show("Producto Eleminado");
            }
            else
            {

                MessageBox.Show("Error al Eleminar Producto");
            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtid.Text = "";
            Txtdescripcion.Text = "";
            Txtcantidad.Text = "";
            Txtidbusqueda.Text = "";
            Txtprecioconiva.Text = "";
            Txtpreciosiniva.Text = "";
            Txtprovee1.Text = "";
            Txtprovee2.Text = "";
            Cbiva.Text = "";
            Txtid.Focus();
        }

        private void Btncalcular_Click_1(object sender, EventArgs e)
        {
            double iva = Convert.ToDouble(Cbiva.Text);
            double preciosiniva = Convert.ToDouble(Txtpreciosiniva.Text);
            double total;
            if (iva == 5)
            {
                total = (preciosiniva * 0.05)+preciosiniva;
                Txtprecioconiva.Text = total.ToString();
            }
            else if (iva == 10)
            {
                total = (preciosiniva * 0.10)+preciosiniva;
                Txtprecioconiva.Text = total.ToString();
            }
            else if (iva == 13)
            {
                total = (preciosiniva * 0.13)+preciosiniva;
                Txtprecioconiva.Text = total.ToString();
            }
            else
            {
                try
                {
                    MessageBox.Show("Debe de Dijitar un impuesto");
                }
                catch
                {
                    MessageBox.Show("Debe de Dijitar un impuesto");

                }
            }

        }

       

      

       
    }
}
