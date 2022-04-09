using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public class ManejadorTipoPlanta : IManejadorTipoPlanta
    {
        public IRepositorioTipoPlanta RepoTipoPlanta { get; set; }

        public bool AddTipoPlanta(TipoPlanta t)
        {

            bool ok = false;

            if (t.SoyValido())
            {
                ok = RepoTipoPlanta.Add(t);
            }

            return ok;

        }

        public IEnumerable<TipoPlanta> FindAllTipoPlanta()
        {
            return RepoTipoPlanta.FindAll();
            
        }

        public TipoPlanta FindByIdTipoPlanta(int id)
        {
            return RepoTipoPlanta.FindById(id);
            
        }

        public bool RemoveTipoPlanta(int id)
        {
            bool ok = false;

            TipoPlanta tipo = RepoTipoPlanta.FindById(id);
            if (tipo != null)
            {
                ok = RepoTipoPlanta.Remove(id);
            }

            return ok;
        }

        public bool UpdateTipoPlanta(TipoPlanta t)
        {
            bool ok;

            TipoPlanta check = RepoTipoPlanta.FindById(t.Id);
            if (t == check)
            {
                ok = true;
            }
            else
            {
                ok = RepoTipoPlanta.Update(t);
            }


            return ok;
        }

       

    }
}
