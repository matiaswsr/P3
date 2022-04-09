using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.InterfacesRepositorio
{
    public interface IRepositorioPlanta : IRepositorio<Planta>
    {
        IEnumerable<Planta> FindAllNombre(string texto);

        IEnumerable<Planta> FindAllTipo(int idTipo);
        IEnumerable<Planta> FindAllAmbiente(int idAmbiente);
        IEnumerable<Planta> FindAllAlturaMax(double alturaMax);
        IEnumerable<Planta> FindAllAlturaMin(double alturaMin);

    }
}
