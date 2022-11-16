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
        //Cadena de Conexion
        string cadena = "data source = DESKTOP-D9LJ3R4\\SQLEXPRESS; initial catalog = MediClicDB; Integrated Security=True;";

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

