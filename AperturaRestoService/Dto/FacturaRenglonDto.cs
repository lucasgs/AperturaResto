﻿using System;

namespace AperturaRestoService.Dto
{
    public class FacturaRenglonDto
    {
        public int NumeroRenglon { get; set; }
        public double Cantidad { get; set; }
        public String CodigoArticulo { get; set; }
        public String DescripcionArticulo { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
    }
}
