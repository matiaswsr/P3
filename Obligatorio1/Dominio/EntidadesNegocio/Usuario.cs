using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Usuario: IValidable
    {
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        public int Id { get; set; }

        public bool SoyValido()
        {
            //PENDIENTE
            throw new NotImplementedException();
        }
    }
}
