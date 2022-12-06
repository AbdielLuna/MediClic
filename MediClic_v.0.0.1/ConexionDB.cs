using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClic_v._0._0._1
{
    internal class ConexionDB
    {
        //Conexion en la nube
        static string servidor = "sql8002.site4now.net";
        static string bd = "db_a90a16_mediclicdb";
        static string usuario = "db_a90a16_mediclicdb_admin";
        static string password = "lunal321";

        string cadena = "Data Source=" + servidor + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
        
        //Conexion de Prueba HostLocal
        //string cadena = "data source = DESKTOP-D9LJ3R4\\SQLEXPRESS; initial catalog = MediClic; Integrated Security=True;";


        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public ConexionDB()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Conexion BD ", ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }

    }
    }

