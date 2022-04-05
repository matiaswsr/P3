using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    abstract class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public  List<Item> Productos { get; set; }
        public double PrecioTotal { get; set; }


    }
}
