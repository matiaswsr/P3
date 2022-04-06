using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    interface IManejadorCompra
    {
        bool AddCompra(Compra c);
        bool RemoveCompra(int id);
        bool UpdateCompra(Compra c);
        IEnumerable<Compra> FindAllCompra();
        Compra FindByIdCompra(int id);
    }
}
