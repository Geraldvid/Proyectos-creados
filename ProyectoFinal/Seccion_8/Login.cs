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
using MySql.Data.MySqlClient;

namespace Seccion_8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        Menu_Principal frm = new Menu_Principal();

        public struct Vendedor
        {
            public string nomvendedor;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bool conectado = fn.Conectar();
            if (conectado == true)
            {
                MessageBox.Show("Conexión Realizada");
            }
            else
            {
                MessageBox.Show("Conexión Fallida", "Error al Conectarse con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Olvidocontra_Click(object sender, EventArgs e)
        {
            this.Hide();

            OlvidoContra frm = new OlvidoContra();

            frm.Show();
            
        }

        private void Nuevovende_Click(object sender, EventArgs e)
        {
            this.Hide();

            Nuevovendedor frm = new Nuevovendedor();

            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Btningresar_Click(object sender, EventArgs e)
        {
            

            if (TxtUsuario.Text == "" ||  Txtcontra.Text == "")
            {
                MessageBox.Show("Error de Datos de Validacion");
            }
            else
            {
                fn.conexion.Open();

                string consulta = ("select * from vendedor where Cedula_Vende = '" + TxtUsuario.Text + "'AND Contra_Vende = '" + Txtcontra.Text + "'");
                

                MySqlCommand cmd = new MySqlCommand(consulta, fn.conexion);

                //filas = Convert.ToInt32(cmd.ExecuteScalar());
                MySqlDataReader lector = cmd.ExecuteReader();
                if (lector.HasRows == true)
                {
                    while (lector.Read())
                    {
                        Vendedorcedu.ceduven = lector.GetString(0);

                    }
                    MessageBox.Show("Acceso Concedido");

                    this.Hide();

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
                fn.conexion.Close();
            }

            
            
            
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        int posY = 0;
        int posX = 0;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
