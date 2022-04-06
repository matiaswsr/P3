using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public interface IManejadorPlanta
    {
        bool AddTipoPlanta(Planta p);
        bool RemovePlanta(int id);
        bool UpdatePlanta(Planta p);
        IEnumerable<Planta> FindAllPlanta();
        Planta FindByIdPlanta(int id);
    }
}
