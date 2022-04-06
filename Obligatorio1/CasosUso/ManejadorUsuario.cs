using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public class ManejadorUsuario: IManejadorUsuario
    {
        public IRepositorioUsuario RepoUsuario { get; set; }


        public ManejadorUsuario(IRepositorioUsuario repo)
        {
            RepoUsuario = repo;
        }

        public bool AddUsuario(Usuario u)
        {
            return RepoUsuario.Add(u);
        }

        public bool RemoveUsuario(int id)
        {
            return RepoUsuario.Remove(id);
        }

        public bool UpdateUsuario(Usuario u)
        {
            return RepoUsuario.Update(u);
        }

        public IEnumerable<Usuario> FindAllUsuario()
        {
            return RepoUsuario.FindAll();
        }

        public Usuario FindByIdUsuario(int id)
        {
            return RepoUsuario.FindById(id);
        }

        //RESTO DE OPERACIONES FUNCIONALIDADES (CASOS DE USO) DE USUARIO

    }
}
