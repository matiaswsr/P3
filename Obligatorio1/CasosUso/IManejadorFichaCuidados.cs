using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorFichaCuidados
    {
        bool AddFichaCuidados(FichaCuidados f);
        bool RemoveFichaCuidados(int id);
        bool UpdateFichaCuidados(FichaCuidados f);
        IEnumerable<FichaCuidados> FindAllFichaCuidados();
        FichaCuidados FindByIdFichaCuidados(int id);
    }
}
