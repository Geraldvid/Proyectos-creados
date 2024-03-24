using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class Funciones
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt;
        

        public int CeduCliente(string cedula)
        {
            int filas;

            conexion.Open();

            string consulta = ("select Cedula_Cliente from proyecto_final_gerald_castro.cliente where Cedula_Cliente = "+ cedula +"'");

            cmd = new MySqlCommand(consulta, conexion);

            filas = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return filas;
        }

        public int CeduVendedor(string cedula)
        {
            int filas;

            conexion.Open();

            string consulta = ("selec Cedula_Vende from proyecto_final_gerald_castro.vendedor where Cedula_Vende = " + cedula + "'");

            cmd = new MySqlCommand(consulta, conexion);

            filas = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return filas;
        }




       public MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=proyecto_final_gerald_castro;User=root;Password=GDCS200305;port=3306");




        //METODO DE CONEXIÓN
        public bool Conectar()
        {
            bool conectado = false;

            try
            {
                conexion.Open();
                conectado = true;
            }
            catch (MySqlException ex)
            {
                conectado = false;
            }
            finally
            {
                conexion.Close();
            }
            return conectado;
        }

        public bool Insertar(string consulta)
        {
            bool agregado = false;
            int filas = 0;

            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);

            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch
            {
                filas = 0;
            }

            if (filas > 0)
            {
                agregado = true;
            }
            conexion.Close();

            return agregado;
        }

        //Metodo de Recuperacion de contraseña
        public DataTable RecuperarContra(string consulta)
        {
            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);

            da = new MySqlDataAdapter(cmd);

            dt = new DataTable();

            da.Fill(dt);

            conexion.Close();

            return dt;
        }
        public bool Modificar(string consulta)
        {
            bool modificar = false;
            int filas = 0;

            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);

            filas = cmd.ExecuteNonQuery();

            if (filas > 0)
            {
                modificar = true;
            }
            conexion.Close();

            return modificar;
        }

        public bool Eleminar(string consulta)
        {
            bool eleminar = false;
            int filas = 0;

            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);

            filas = cmd.ExecuteNonQuery();

            if (filas > 0)
            {
                eleminar = true;
            }
            conexion.Close();

            return eleminar;
        }
        
        
        public int ContarClientes()
        {
            int filas;

            conexion.Open();

            string consulta = ("SELECT COUNT(*) FROM proyecto_final_gerald_castro.cliente;");

            cmd = new MySqlCommand(consulta, conexion);

            filas = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return filas;
        }
        public int ContarProductos()
        {
            int filas;

            conexion.Open();

            string consulta = ("SELECT COUNT(*) FROM proyecto_final_gerald_castro.producto;");

            cmd = new MySqlCommand(consulta, conexion);

            filas = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return filas;
        }

        public int ContarProveedores()
        {
            int filas;

            conexion.Open();

            string consulta = ("SELECT COUNT(*) FROM proyecto_final_gerald_castro.vendedor;");

            cmd = new MySqlCommand(consulta, conexion);

            filas = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return filas;
        }
        //public int SumarTotalVenta()
        //{

        //    int filas = 0;

        //    conexion.Open();

        //    string consulta = ("SELECT SUM(Total_Factura) FROM proyecto_final_gerald_castro.factura;");

        //    cmd = new MySqlCommand(consulta, conexion);

        //     filas = Convert.ToInt32(cmd.ExecuteScalar());

        //    conexion.Close();

        //    return filas;
        //}
        
        //public int TotalCaja()
        //{
        //    int filas;

        //    conexion.Open();

        //    string consulta = ("SELECT SUM(Total_Factura) FROM proyecto_final_gerald_castro.factura where TipoPago_Factura = 'Efectivo';");

        //    cmd = new MySqlCommand(consulta, conexion);

        //    filas = Convert.ToInt32(cmd.ExecuteScalar());

        //    conexion.Close();

        //    return filas;
        //}

       

        //#endregion

        public int IDFacturar()
        {
            int numFactura = 0;
            conexion.Open();
            string consulta = "SELECT Numero_Factura FROM proyecto_final_gerald_castro.factura order by Numero_Factura desc limit 0, 1";
            cmd = new MySqlCommand(consulta, conexion);
            numFactura = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return numFactura;
        }

        //public int NomVendedor(string vendedor)
        //{

        //    int filas;

        //    conexion.Open();

        //    string consulta = ("select Nom_Vende from proyecto_final_gerald_castro.vendedor where Cedula_Vende = "+ vendedor + "'");

        //    cmd = new MySqlCommand(consulta, conexion);

        //    filas = Convert.ToInt32(cmd.ExecuteScalar());

        //    conexion.Close();

        //    return filas;
        //}


        
    }
}
