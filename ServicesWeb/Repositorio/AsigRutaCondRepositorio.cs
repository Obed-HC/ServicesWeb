using ServicesWeb.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesWeb.Repositorio
{
    public class AsigRutaCondRepositorio
    {
        public static bool AsignarRutaConductor(AsigRutaCond oAsigRutaCond)
        {
            string sp = StoredProcedure.USP_ASIGNAR_RUTA_CONDUCTOR;

            using (SqlConnection oConexion = new SqlConnection(ConexionBD.rutaConexion))
            {
                bool respuesta = false;
                SqlCommand parametros = new SqlCommand(sp, oConexion);
                parametros.CommandType = CommandType.StoredProcedure;
                parametros.Parameters.AddWithValue("@x_nCodigoRuta", oAsigRutaCond.nCodigoRuta.ToString());
                parametros.Parameters.AddWithValue("@x_nCodigoCond", oAsigRutaCond.nCodigoCond.ToString());
                parametros.Parameters.AddWithValue("@x_dFechaInicio", oAsigRutaCond.dFechaInicio.ToString());
                parametros.Parameters.AddWithValue("@x_dFechaFin", oAsigRutaCond.dFechaFin.ToString());
                parametros.Parameters.AddWithValue("@x_nCodigoAdm", oAsigRutaCond.nCodigoAdm.ToString());

                try
                {
                    oConexion.Open();
                    parametros.ExecuteNonQuery();

                    respuesta = true;
                    return respuesta;
                }
                catch (Exception ex)
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
    }
}
