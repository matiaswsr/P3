using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Importacion: Compra
    {
        public string MedidasSanitarias { get; set; }
        public double TasaImpuestosDGI { get; set; }
        public double TasaAmSur { get; set; }
        public bool PerteneceAmSur { get; set; }

        
        public override string Tipo()
        {
            return "Importacion";
        }
    }
}
