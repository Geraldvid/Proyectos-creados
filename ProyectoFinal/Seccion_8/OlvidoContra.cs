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
    public partial class OlvidoContra : Form
    {
        public OlvidoContra()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();

        private void Btnregistrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Consulta
                Dgcontra.DataSource = fn.RecuperarContra("select * from vendedor where Cedula_Vende = '" + Txtcedula.Text + "'AND Pregunta_Vende = '" + Cbpreguntasecreta.Text + "'AND Respuesta_Vende ='" + Txtrespuestasecreta.Text + "'");
          
            }
            catch
            {
                MessageBox.Show("Datos Incorrectos");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login frm = new Login();

            frm.Show();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Txtcedula.Clear();
            Txtrespuestasecreta.Clear();
            Cbpreguntasecreta.Text = "";
            Txtcedula.Focus();
        }
    }
}
