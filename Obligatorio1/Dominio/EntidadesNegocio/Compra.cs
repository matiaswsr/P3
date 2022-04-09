using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public abstract class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public  List<Item> Productos { get; set; }
        public double PrecioTotal { get; set; }

        public bool Validar()
        {
            //PENDIENTE
            throw new NotImplementedException();
            
        }

        public abstract string Tipo();

    }
}
