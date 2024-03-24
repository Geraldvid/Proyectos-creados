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
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        Factura fact = new Factura();
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string insert = "insert into cliente values('" + Txtcedu.Text + "','" + Txtnombre.Text + "', '" + Txtdomifisico.Text + "','" + Txttelef1.Text + "','" + Txttelef2.Text + "','" + Txtcodigopos.Text + "','" + TxtCorreo.Text + "','" + Txtdomifiscal.Text + "')";
            if (fn.Insertar(insert))
            {
                MessageBox.Show("Cliente agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar o el cliente ya esta agregado", "Error al agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            string modificar = "update cliente set Nom_Cliente = '" + Txtnombre.Text + "', DomiciFisico_Cliente = '" + Txtdomifisico.Text + "', Telefono1_Cliente = '" + Txttelef1.Text + "',Telefono2_Cliente = '" + Txttelef2.Text + "', CodigoPostal_Cliente = '" + Txtcodigopos.Text + "', Correo_Cliente = '" + TxtCorreo.Text + "', DomicilioFiscal_Cliente = '" + Txtdomifiscal.Text + "' where Cedula_Cliente = " + Txtcedu.Text;

            if (fn.Modificar(modificar))
            {
                MessageBox.Show("Cliente Modificado");
            }
            else
            {
                MessageBox.Show("Error al Modificar el Cliente");

            }
        }

        private void BtnEleminar_Click(object sender, EventArgs e)
        {
            string eleminar = "delete from cliente where Cedula_Cliente =  " + Txtcedu.Text;

            if (fn.Eleminar(eleminar))
            {
                MessageBox.Show("Cliente Eliminado");
            }
            else
            {

                MessageBox.Show("Error al Eliminar el Cliente");
            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtcedu.Text = "";
            Txtcodigopos.Text = "";
            TxtCorreo.Text = "";
            Txtdomifiscal.Text = "";
            Txtdomifisico.Text = "";
            Txtidbusqueda.Text = "";
            Txtnombre.Text = "";
            Txttelef1.Text = "";
            Txttelef2.Text = "";
            Txtcedu.Focus();
        }

        private void Btnbuscarid_Click(object sender, EventArgs e)
        {
            try
            {
                DgCliente.DataSource = fn.RecuperarContra("select * from cliente where Cedula_Cliente = '" + Txtidbusqueda.Text + "'");
            }
            catch
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void Btnbuscartodo_Click(object sender, EventArgs e)
        {
            try
            {
                DgCliente.DataSource = fn.RecuperarContra("Select * from cliente");
            }
            catch
            {
                MessageBox.Show("Error al mostrar cliente");
            }
        }

        private void DgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtcedu.Text = DgCliente.CurrentRow.Cells[0].Value.ToString();
            Txtnombre.Text = DgCliente.CurrentRow.Cells[1].Value.ToString();
            Txtdomifisico.Text = DgCliente.CurrentRow.Cells[2].Value.ToString();
            Txttelef1.Text = DgCliente.CurrentRow.Cells[3].Value.ToString();
            Txttelef2.Text = DgCliente.CurrentRow.Cells[4].Value.ToString();
            Txtcodigopos.Text = DgCliente.CurrentRow.Cells[5].Value.ToString();
            TxtCorreo.Text = DgCliente.CurrentRow.Cells[6].Value.ToString();
            Txtdomifiscal.Text = DgCliente.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fact.TxtCliente.Text = DgCliente.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
