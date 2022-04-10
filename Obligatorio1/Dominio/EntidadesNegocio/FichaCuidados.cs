using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class FichaCuidados: IValidable
    {
        public int Id { get; set; }
        public string TipoIluminacion { get; set; }
        public decimal Temperatura { get; set; }
        public string FrecuenciaRiego { get; set; }

        public bool SoyValido()
        {
            //PENDIENTE
            throw new NotImplementedException();
        }
    }
}
