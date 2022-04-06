using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorUsuario
    {
        bool AddUsuario(Usuario u);
        bool RemoveUsuario(int id);
        bool UpdateUsuario(Usuario u);
        IEnumerable<Usuario> FindAllUsuario();
        Usuario FindByIdUsuario(int id);
    }
}
