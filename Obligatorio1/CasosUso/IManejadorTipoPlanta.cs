using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorTipoPlanta
    {
        bool AddTipoPlanta(TipoPlanta t);
        bool RemoveTipoPlanta(int id);
        bool UpdateTipoPlanta(TipoPlanta t);
        IEnumerable<TipoPlanta> FindAllTipoPlanta();
        TipoPlanta FindByIdTipoPlanta(int id);
    }
}
