using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    class ManejadorTipoPlanta:IManejadorTipoPlanta
    {
        public IRepositorioTipoPlanta RepoTipoPlanta { get; set; }
    }
}
