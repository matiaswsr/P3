using Dominio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public class ManejadorFichaCuidados : IManejadorFichaCuidados
    {
        public IRepositorioFichaCuidados RepoFichaCuidados { get; set; }
        public bool AddFichaCuidados(FichaCuidados f)
        {
            bool ok = false;
            if (f.SoyValido())
            {
                ok = RepoFichaCuidados.Add(f);
            }
            return ok;
        }

        public IEnumerable<FichaCuidados> FindAllFichaCuidados()
        {
            return RepoFichaCuidados.FindAll();
        }

        public FichaCuidados FindByIdFichaCuidados(int id)
        {
            return RepoFichaCuidados.FindById(id);
        }

        public bool RemoveFichaCuidados(int id)
        {
            bool ok = false;

            FichaCuidados f = RepoFichaCuidados.FindById(id);
            if (f != null)
            {
                RepoFichaCuidados.Remove(id);
            }

            return ok;
        }

        public bool UpdateFichaCuidados(FichaCuidados f)
        {
            bool ok;

            FichaCuidados check = RepoFichaCuidados.FindById(f.Id);
            if (f == check)
            {
                ok = true;
            }
            else
            {
                ok = RepoFichaCuidados.Update(f);
            }


            return ok;
        }
    }
}
