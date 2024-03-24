using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Datos;

namespace Seccion_8
{
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();

        private void Inicio_Load(object sender, EventArgs e)
        {
            fn.Conectar();
            Grafica.Series["Productos"].LegendText = "Cantidad de Productos";
            Grafica.Series["Productos"].XValueMember = "Descrip_Producto";
            Grafica.Series["Productos"].YValueMembers = "Cantidad_Producto";
            Grafica.DataSource = fn.RecuperarContra("select Descrip_Producto, Cantidad_Producto from producto");


            Mas_Vendidos.Series["Datos"].LegendText = "";
            Mas_Vendidos.Series["Datos"].XValueMember = "Descrip_Producto";
            Mas_Vendidos.Series["Datos"].YValueMembers = "Precio_con_iva_Producto";
            Mas_Vendidos.DataSource = fn.RecuperarContra("select Descrip_Producto, Precio_con_iva_Producto from producto");

            Ncliente.Text = Convert.ToString(fn.ContarClientes());
            Nproduc.Text = Convert.ToString(fn.ContarProductos());
            Nprovee.Text = Convert.ToString(fn.ContarProveedores());

            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            LbReloj.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
