using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{

    public enum TipoAmbiente { Interior, Exterior, Mixta }
    public class Planta: IValidable
    {
        

        public int Id { get; set; }
        public TipoPlanta Tipo { get; set; }
        public string NombreCientifico { get; set; }
        public string Descripcion { get; set; }
        public List<string> NombresVulgares { get; set; }
        public TipoAmbiente Ambiente { get; set; }
        public decimal AlturaMax { get; set; }

        public string Foto { get; set; }

        public FichaCuidados Ficha { get; set; }

        
        public bool SoyValido()
        {
            //PENDIENTE
            throw new NotImplementedException();
        }
    }
}
