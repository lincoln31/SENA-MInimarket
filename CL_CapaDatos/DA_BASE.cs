using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CL_CapaDatos
{
    public class DA_BASE
    {


        public static string CadenaConexion = "SERVER=localhost; DATABASE=minimarket; UID=root; PASSWORD=";

        //Sentencias insert, update y delete
        public static bool RealizarTransaccion(string strSQL)
        {
            bool resultado = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlTransaction tr = conn.BeginTransaction())
                    {
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                            {
                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                            tr.Commit();
                            resultado = true;
                        }
                        catch (Exception)
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }

            return resultado;
        }
        //consulta de datos - sentenciaSelect

        public static DataTable consultarDatos(String strSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

       



    }

    

}
