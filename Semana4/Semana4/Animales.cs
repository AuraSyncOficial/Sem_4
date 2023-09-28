using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    class Animales
    {
        public string Nombre { get; }
        public int TiempoDeVida { get;  set; }
        public int CarneProductosPorAnimal { get; }
        public int PrecioAnimal { get; }
        public int ProductoFinal { get; }

        public int tiempoDeVidaInicial;

        public Animales(string nombre, int tiempoDeVida, int carneProductosPorAnimal, int precioAnimal, int productoFinal)
        {
            Nombre = nombre;
            tiempoDeVidaInicial = tiempoDeVida;
            TiempoDeVida = tiempoDeVida;
            CarneProductosPorAnimal = carneProductosPorAnimal;
            PrecioAnimal = precioAnimal;
            ProductoFinal = productoFinal;
        }

        public void Crecer()
        {
            if (TiempoDeVida > 0)
            {
                TiempoDeVida--;
            }
        }
        public void RestaurarTiempoDeVidaInicial()
        {
            TiempoDeVida = tiempoDeVidaInicial;
        }

    }
}
