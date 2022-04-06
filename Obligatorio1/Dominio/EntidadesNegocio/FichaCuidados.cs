using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class FichaCuidados
    {
        public int Id { get; set; }
        public string TipoIluminacion { get; set; }
        public double Temperatura { get; set; }
        public string FrecuenciaRiego { get; set; }
    }
}
