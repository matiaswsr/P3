using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    class ManejadorPlanta: IManejadorPlanta
    {
        public IRepositorioPlanta RepoPlanta { get; set; }
    }
}
