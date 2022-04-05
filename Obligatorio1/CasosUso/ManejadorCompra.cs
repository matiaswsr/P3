using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    class ManejadorCompra: IManejadorCompra

    {
        public IRepositorioCompra RepoCompra { get; set; }
    }
}
