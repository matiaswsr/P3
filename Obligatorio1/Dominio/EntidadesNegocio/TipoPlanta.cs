using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class TipoPlanta: IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool SoyValido()

        { //PENDIENTE
            throw new NotImplementedException();
        }

        

    }
}
