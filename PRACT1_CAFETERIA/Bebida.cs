using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT1_CAFETERIA
{
    internal class Bebida
    {
        private string nombre;
        private string tamano;
        private float precio;

        public Bebida(string nombre, string tamano, float precio)
        {
            this.nombre = nombre;
            this.tamano = tamano;
            this.precio = precio;
        }

        public void Preparar()
        {
            Console.WriteLine($"PREPARANDO UN {nombre} TAMAÑO {tamano}...");
        }

        public void AplicarDescuento(float porcentaje)
        {
            float descuento = precio * (porcentaje / 100);
            precio = precio - descuento;
        }

        public void MostrarDescripcion()
        {
            Console.WriteLine($"ESTO ES {nombre} DEL TAMAÑO {tamano} CON UN COSTO DE ${precio}");
        }
    }
}
