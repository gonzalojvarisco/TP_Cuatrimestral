﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public IList<Proveedor> Proveedores { get; set; }
        public TipoProducto Tipo { get; set; }
        public Marca Marca { get; set; }
        public string Codigo { get; set; }
        public Decimal PrecioCosto { get; set; }
        public Decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }

        public override string ToString()
        {
            return Tipo.ToString();//+ ',' + Marca.ToString();
        }

    }
}
