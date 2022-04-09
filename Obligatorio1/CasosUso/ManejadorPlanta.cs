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

        public IRepositorioTipoPlanta RepoTipoPlanta { get; set;}

        public IRepositorioFichaCuidados RepoFichaCuidados { get; set; }

        public ManejadorPlanta( IRepositorioTipoPlanta repoTipoPlanta, IRepositorioPlanta repoPlanta, IRepositorioFichaCuidados repoFichaCuidados)
        {
            RepoFichaCuidados = repoFichaCuidados;
            RepoPlanta = repoPlanta;
            RepoTipoPlanta = repoTipoPlanta;
        }

        public bool AddTipoPlanta(Planta p, int IdTipoPlanta, int IdFichaCuidados)
        {
            bool ok = false;

            if (p.SoyValido())
            {

                TipoPlanta tipo = RepoTipoPlanta.FindById(IdTipoPlanta);

                if(tipo != null)
                {
                    FichaCuidados ficha = RepoFichaCuidados.FindById(IdFichaCuidados);

                    if(ficha != null)
                    {
                        p.Ficha = ficha;
                        p.Tipo = tipo;
                        ok = RepoPlanta.Add(p);
                    }
                }


            }

            return ok;
        }

        public IEnumerable<Planta> FindAllPlanta()
        {
            return RepoPlanta.FindAll();
        }

        public Planta FindByIdPlanta(int id)
        {
            return RepoPlanta.FindById(id);
            
        }

        public bool RemovePlanta(int id)
        {
            bool ok = false;

            Planta p = RepoPlanta.FindById(id);
            if(p != null)
            {
                RepoPlanta.Remove(id);
            }

            return ok;

        }

        public bool UpdatePlanta(Planta p)
        {
            bool ok;

            Planta check = RepoPlanta.FindById(p.Id);
            if(p == check)
            {
                ok = true;
            }
            else
            {
                ok = RepoPlanta.Update(p);
            }


            return ok;
        }

        public IEnumerable<TipoPlanta> FindAllTipoPlanta()
        {
            return RepoTipoPlanta.FindAll();
        }

        public IEnumerable<FichaCuidados> FindAllFichaCuidados()
        {
            return RepoFichaCuidados.FindAll();
        }


        public IEnumerable<Planta> FindAllPlantaNombre(string texto)
        {
            return RepoPlanta.FindAllNombre(texto);
        }

        public IEnumerable<Planta> FindAllTipo(int idTipo)
        {
            return RepoPlanta.FindAllTipo(idTipo);
        }

        public IEnumerable<Planta> FindAllAmbiente(int idAmbiente)
        {
            return RepoPlanta.FindAllAmbiente(idAmbiente);
        }
        public IEnumerable<Planta> FindAllAlturaMax(double alturaMax)
        {
            return RepoPlanta.FindAllAlturaMax(alturaMax);
        }

        public IEnumerable<Planta> FindAllAlturaMin(double alturaMin)
        {
            return RepoPlanta.FindAllAlturaMin(alturaMin);
        }


    }
}
