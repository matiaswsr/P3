using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorUsuario
    {
        bool AgregarNuevoUsuario(Usuario u);

        bool DarDeBajaUsuario(int id);

        IEnumerable<Usuario> TraerTodosUsuario();
    }
}
