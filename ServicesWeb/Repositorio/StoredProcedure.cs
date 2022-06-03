﻿using System;
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

        #region Ruta
        public const string USP_LISTAR_RUTAS = "ListRutas_sp";
        #endregion

        #region Denuncia Ciudadano
        public const string USP_INSERTAR_DENUNCIA = "InsDenunciaCiud_sp";
        public const string USP_CAMBIAR_ESTADO_DENUNCIA = "UpdDenunciaCiud_sp";
        public const string USP_LISTAR_FILTRO_DENUNCIA = "ListDenunciasCiudadano_sp";
        #endregion

        #region Reclamo Ciudadano
        public const string USP_INSERTAR_RECLAMO_CIUDADANO = "InsReclamoCiud_sp";
        public const string USP_CAMBIAR_ESTADO_RECLAMO_CIUDADANO = "UpdReclamoCiud_sp";
        public const string USP_LISTAR_FILTRO_RECLAMO_CIUDADANO = "ListReclamosCiudadano_sp";
        #endregion

        #region Reclamo Conductor
        public const string USP_INSERTAR_RECLAMO_CONDUCTOR = "InsReclamoCond_sp";
        public const string USP_CAMBIAR_ESTADO_RECLAMO_CONDUCTOR = "UpdReclamoCond_sp";
        public const string USP_LISTAR_FILTRO_RECLAMO_CONDUCTOR = "ListReclamosConductor_sp";
        #endregion

        #region Asignar Ruta a Conductor
        public const string USP_ASIGNAR_RUTA_CONDUCTOR = "AsigRutaConductor_sp";
        public const string USP_LISTAR_RUTAS_CONDUCTORES = "ListRutaConductor_sp";
        #endregion

        #region AÑADIENDO PUSH
        #endregion


    }
}
