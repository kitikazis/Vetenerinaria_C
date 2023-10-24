using System;
using System.Data;
using System.Data.SqlClient;

namespace VeterinariaPet.datos
{
    internal class Conexion
    {
        private SqlConnection cnn;

        protected bool Conectado()
        {
            try
            {
                cnn = new SqlConnection("Data Source=localhost;Initial Catalog=dbventas;Integrated Security=True");
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        protected bool Desconectado()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
