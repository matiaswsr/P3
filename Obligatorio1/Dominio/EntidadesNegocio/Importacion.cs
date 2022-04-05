using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    class Importacion: Compra
    {
        public string MedidasSanitarias { get; set; }
        public double TasaImpuestosDGI { get; set; }
        public double TasaAmSur { get; set; }
        public bool PerteneceAmSur { get; set; }
    }
}
