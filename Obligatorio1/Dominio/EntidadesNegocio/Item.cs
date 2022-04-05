using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    class Item
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public Planta Producto { get; set; }
        public double PrecioUnitario { get; set; }

    }
}
