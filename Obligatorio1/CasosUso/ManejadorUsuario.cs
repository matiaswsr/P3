using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    class ManejadorUsuario: IManejadorUsuario
    {
        public IRepositorioUsuario RepoUsuario { get; set; }


        public ManejadorUsuario(IRepositorioUsuario repo)
        {
            RepoUsuario = repo;
        }

        public bool AgregarNuevoUsuario(Usuario u)
        {
            return RepoUsuario.Add(c);
        }

        public bool DarDeBajaUsuario(int id)
        {
            return RepoUsuario.Remove(id);
        }

        public IEnumerable<Usuario> TraerTodosUsuario()
        {
            return RepoUsuario.FindAll();
        }

        //RESTO DE OPERACIONES CRUD y FUNCIONALIDADES (CASOS DE USO) DE USUARIO

    }
}
