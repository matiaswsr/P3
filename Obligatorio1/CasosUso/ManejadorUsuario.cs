using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public class ManejadorUsuario : IManejadorUsuario
    {
        public IRepositorioUsuario RepoUsuario { get; set; }


        public ManejadorUsuario(IRepositorioUsuario repo)
        {
            RepoUsuario = repo;
        }

        public bool AddUsuario(Usuario u)
        {
            bool ok = false;
            if (u.SoyValido())
            {
                ok = RepoUsuario.Add(u);
            }
            return ok;
        }

        public bool RemoveUsuario(int id)
        {
            bool ok = false;

            Usuario check = RepoUsuario.FindById(id);
            if (check != null) { ok = RepoUsuario.Remove(id); }

            return ok;
        }

        public bool UpdateUsuario(Usuario u)
        {

            bool ok;

            Usuario check = RepoUsuario.FindById(u.Id);
            if (u == check)
            {
                ok = true;
            }
            else
            {
                ok = RepoUsuario.Update(u);
            }


            return ok;
        }

        public IEnumerable<Usuario> FindAllUsuario()
        {
            return RepoUsuario.FindAll();
        }

        public Usuario FindByIdUsuario(int id)
        {
            return RepoUsuario.FindById(id);
        }


    }
}
