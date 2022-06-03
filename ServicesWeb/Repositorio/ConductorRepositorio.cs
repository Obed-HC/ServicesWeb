using ServicesWeb.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesWeb.Repositorio
{
    public class ConductorRepositorio
    {
        public static bool Grabar(Conductor oConductor)
        {
            string sp = StoredProcedure.USP_CONDUCTOR_GRABAR;

            using (SqlConnection oConexion = new SqlConnection(ConexionBD.rutaConexion))
            {
                bool respuesta = false;
                SqlCommand parametros = new SqlCommand(sp, oConexion);
                parametros.CommandType = CommandType.StoredProcedure;
                parametros.Parameters.AddWithValue("@x_cNombreCond", oConductor.cNombreCond.ToString());
                parametros.Parameters.AddWithValue("@x_cApePatCond", oConductor.cApePatCond.ToString());
                parametros.Parameters.AddWithValue("@x_cApeMatCond", oConductor.cApeMatCond.ToString());
                parametros.Parameters.AddWithValue("@x_cDNICond", oConductor.cDNICond.ToString());
                parametros.Parameters.AddWithValue("@x_cEdadCond", oConductor.cEdadCond.ToString());
                parametros.Parameters.AddWithValue("@x_cCelCond", oConductor.cCelCond.ToString());
                parametros.Parameters.AddWithValue("@x_cDireccCond", oConductor.cDireccCond.ToString());
                parametros.Parameters.AddWithValue("@x_cCorEleCond", oConductor.cCorEleCond.ToString());

                try
                {
                    oConexion.Open();
                    parametros.ExecuteNonQuery();

                    respuesta = true;
                    return respuesta;
                }
                catch (IOException e)
                {
                    respuesta = false;
                    return respuesta;
                }
                finally
                {
                    oConexion.Close();
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
