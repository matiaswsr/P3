using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorio;

namespace Repositorios
{
    class RepositorioPlanta : IRepositorioPlanta
    {
        public bool Add(Planta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllAlturaMax(double alturaMax)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllAlturaMin(double alturaMin)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllAmbiente(int idAmbiente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllNombre(string texto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planta> FindAllTipo(int IdTipo)
        {
            throw new NotImplementedException();
        }

        public Planta FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Planta obj)
        {
            throw new NotImplementedException();
        }
    }
}
