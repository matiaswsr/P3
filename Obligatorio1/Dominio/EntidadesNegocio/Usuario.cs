﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Usuario: IValidable
    {
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        bool IValidable.SoyValido()
        {
            throw new NotImplementedException();
        }
    }
}
