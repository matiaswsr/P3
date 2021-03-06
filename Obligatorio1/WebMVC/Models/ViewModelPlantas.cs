using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Microsoft.AspNetCore.Http;

namespace WebMVC.Models
{
    public class ViewModelPlantas
    {
        public IEnumerable<TipoPlanta> Tipos { get; set; }
        public IEnumerable<FichaCuidados> Fichas { get; set; }

        public IFormFile Imagen { get; set; }

        public int IdTipo { get; set; }
        public int IdFicha { get; set; }

        public Planta Planta { get; set; }


    }
}
