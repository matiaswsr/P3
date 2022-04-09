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
            bool ok = false;
            if (c.Validar())
            {
                ok = RepoCompra.Add(c);
            }
            return ok;
        }

        public IEnumerable<Compra> FindAllCompra()
        {
            return RepoCompra.FindAll();
        }

        public Compra FindByIdCompra(int id)
        {
            return RepoCompra.FindById(id);
        }

        public bool RemoveCompra(int id)
        {
            bool ok = false;

            Compra c = RepoCompra.FindById(id);
            if (c != null)
            {
                RepoCompra.Remove(id);
            }

            return ok;
        }

        public bool UpdateCompra(Compra c)
        {
            bool ok;

            Compra check = RepoCompra.FindById(c.Id);
            if (c == check)
            {
                ok = true;
            }
            else
            {
                ok = RepoCompra.Update(c);
            }


            return ok;
        }


    }
}
