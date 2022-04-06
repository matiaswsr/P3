using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public class ManejadorTipoPlanta:IManejadorTipoPlanta
    {
        public IRepositorioTipoPlanta RepoTipoPlanta { get; set; }

        public bool AddTipoPlanta(TipoPlanta t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoPlanta> FindAllTipoPlanta()
        {
            throw new NotImplementedException();
        }

        public TipoPlanta FindByIdTipoPlanta(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTipoPlanta(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTipoPlanta(TipoPlanta t)
        {
            throw new NotImplementedException();
        }

        //RESTO DE OPERACIONES FUNCIONALIDADES (CASOS DE USO) DE TIPO PLANTA

    }
}
