using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesWeb.Repositorio
{
    public class StoredProcedure
    {
        #region Carro
        public const string USP_LISTAR_CARROS = "ListCarros_sp";
        public const string USP_CARRO_GRABAR = "InsCarro_sp";
        #endregion

        #region Conductor
        public const string USP_LISTAR_CONDUCTORES = "ListConductores_sp";
        public const string USP_CONDUCTOR_GRABAR = "InsConductor_sp";
        #endregion

        #region Asignar Conductor Carro
        public const string USP_CONDUCTOR_CARRO_ASIGNAR = "AsigCondCarro_sp";
        public const string USP_CONDUCTOR_DISPONIBLE_LISTAR = "ListCondDisp_sp";
        public const string USP_CARRO_DISPONIBLE_LISTAR = "ListCarroDisp_sp";
        #endregion

        #region Publicacion
        public const string USP_PUBLICACION_GRABAR = "InsPublicacion_sp";
        #endregion

        #region Calles
        public const string USP_LISTAR_CALLES = "ListCalle_sp";
        #endregion


    }
}
