﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Clases
{
    public class Socio:Persona
    {
        public int idSocio { get; set; }
        public DateTime fechaInscripcion { get; set; }
        public int fk_IdEstado { get; set; }
        public Estado estadoDelSocio { get; set; }

        public  string registrarse()
        {
            return "El socio se registro";
        }

        public override string ToString()
        {
            return "SOCIO N°:"  + this.idSocio + " NOMBRE:" + this.nombre + " APELLIDO:" + this.apellido + " ESTADO: "+this.estadoDelSocio.getEstado();
        }

        
    }
}
