using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace CasosUso
{
    public class ManejadorPlanta: IManejadorPlanta
    {
        public IRepositorioPlanta RepoPlanta { get; set; }

        public bool AddTipoPlanta(Planta p)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllPlanta()
        {
            throw new NotImplementedException();
        }

        public Planta FindByIdPlanta(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemovePlanta(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePlanta(Planta p)
        {
            throw new NotImplementedException();
        }

        //RESTO DE OPERACIONES FUNCIONALIDADES (CASOS DE USO) DE PLANTA

    }
}
