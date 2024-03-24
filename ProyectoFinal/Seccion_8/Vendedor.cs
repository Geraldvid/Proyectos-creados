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
    public partial class Vendedor : UserControl
    {
        public Vendedor()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            string insert = "insert into vendedor values('" + TxtCedula.Text + "','" + TxtNombre.Text + "', '" + TxtDireccion.Text + "','" + Txttelefono.Text + "','" + TxtContra.Text + "','" + Cbpreguntasecreta.Text + "','" + Txtrespuestasecreta.Text + "')";
            if (fn.Insertar(insert))
            {
                MessageBox.Show("Usuario agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar o el vendedor ya esta agregado", "Error al agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txttelefono.Clear();
            Txtrespuestasecreta.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtContra.Clear();
            TxtCedula.Clear();
            Cbpreguntasecreta.Text = "";
            TxtCedula.Focus();
        }
    }
}
