using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public class ManejadorCompra: IManejadorCompra

    {
        public IRepositorioCompra RepoCompra { get; set; }

        public bool AddCompra(Compra c)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compra> FindAllCompra()
        {
            throw new NotImplementedException();
        }

        public Compra FindByIdCompra(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCompra(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompra(Compra c)
        {
            throw new NotImplementedException();
        }

        //RESTO DE OPERACIONES FUNCIONALIDADES (CASOS DE USO) DE COMPRA

    }
}
