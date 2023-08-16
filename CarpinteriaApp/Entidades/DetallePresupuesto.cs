﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Entidades
{
    internal class DetallePresupuesto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        //public DetallePresupuesto()
        //{
        //    Producto = null;
        //    Cantidad = 0;
        //}

        //public DetallePresupuesto(Producto producto, int cantidad)
        //{
        //    Producto = producto;
        //    Cantidad = cantidad;
        //}

        //public override string ToString()
        //{
        //    return Producto.ToString();
        //}

        public double CalcularSubtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}