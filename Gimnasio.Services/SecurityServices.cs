﻿using Gimnasio.Clases;
using Gimnasio.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Services
{
     public class SecurityServices
    {
        DatosMaestros datosMaestros = new DatosMaestros();

        public List<Estado> getEstado()
        {
            return datosMaestros.GetEstado();
        }

        public List<Genero> getGenero()
        {
            return datosMaestros.GetGenero();
        }

        public List<Actividad> getActividad()
        {
            return datosMaestros.GetActividad();
        }
        public int insertPersona(Persona nuevaPersona)
        {
            return datosMaestros.InsertPersona(nuevaPersona);
        }

        public int insertSocio(int idPersona)
        {
            return datosMaestros.InsertSocio(idPersona);
        }

        public int insertDatosProfesor(Profesor profesorNuevo)
        {
            return datosMaestros.InsertDatosProfesor(profesorNuevo);
        }
        public int insertProfesor(int idPersona)
        {
            return datosMaestros.InsertProfesor(idPersona);
        }

        public List<SocioAdmin> getSocios()
        {
            return datosMaestros.GetSocios();
        }

        public List<ProfesorAdmin> getProfesores()
        {
            return datosMaestros.GetProfesores();
        }

        public int editarEstadoSocio(int idSocio, int idEstado)
        {
            return datosMaestros.EditarEstadoSocio(idSocio, idEstado);
        }

        public int actualizarFechaPagoSocio(int idSocio, DateTime fechaUltimoPago)
        {
            return datosMaestros.ActualizarFechaPagoSocio(idSocio, fechaUltimoPago);
        }
    }
}
