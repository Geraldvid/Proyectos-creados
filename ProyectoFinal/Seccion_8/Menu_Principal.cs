using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;


namespace Seccion_8
{
    public partial class Menu_Principal : Form
    {
        
        public Menu_Principal()
        {
           
                InitializeComponent();

                
        }
        Funciones fn = new Funciones();
        private void Btnveendedor_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (Contenedor.Contains(cliente) == false)
            {
                Contenedor.Controls.Add(cliente);
                cliente.Dock = DockStyle.Fill;
                cliente.BringToFront();
                
            }
        }

        private void Btnproducto_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            if(Contenedor.Contains(productos) == false)
            {
                Contenedor.Controls.Add(productos);
                productos.Dock = DockStyle.Fill;
                productos.BringToFront();
                
            }
        }

        private void Btnfactura_Click(object sender, EventArgs e)
        {
            Factura Factura = new Factura();
            if (Contenedor.Contains(Factura) == false)
            {
                Contenedor.Controls.Add(Factura);
                Factura.Dock = DockStyle.Fill;
                Factura.BringToFront();

            }
           
        }

        private void Btningreso_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            if (Contenedor.Contains(vendedor) == false)
            {
                Contenedor.Controls.Add(vendedor);
                vendedor.Dock = DockStyle.Fill;
                vendedor.BringToFront();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            if (Contenedor.Contains(inicio) == false)
            {
                Contenedor.Controls.Add(inicio);
                inicio.Dock = DockStyle.Fill;
                inicio.BringToFront();
            }
            
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login lg = new Login();

            lg.Show();
        }

        private void Panelencabe_Paint(object sender, PaintEventArgs e)
        {

        }
        int posX = 0;
        int posY = 0;

        private void Panelencabe_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            if (Contenedor.Contains(inicio) == false)
            {
                Contenedor.Controls.Add(inicio);
                inicio.Dock = DockStyle.Fill;
                inicio.BringToFront();
            }


            NombreVendedor.Text = Vendedorcedu.ceduven;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void NombreVendedor_Click(object sender, EventArgs e)
        {

        }

       
    }
}
