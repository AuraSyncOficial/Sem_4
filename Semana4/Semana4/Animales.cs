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
        public int TiempoDeVida { get; private set; }
        public int CarneProductosPorAnimal { get; }
        public int PrecioAnimal { get; }
        public int ProductoFinal { get; }

        public Animales(string nombre, int tiempoDeVida, int carneProductosPorAnimal, int precioAnimal, int productoFinal)
        {
            Nombre = nombre;
            TiempoDeVida = tiempoDeVida;
            CarneProductosPorAnimal = carneProductosPorAnimal;
            PrecioAnimal = precioAnimal;
            ProductoFinal = productoFinal;
        }

        public void Crecer()
        {
            TiempoDeVida++;
        }

        public int Vender()
        {
            int animalVendido = CarneProductosPorAnimal;
            TiempoDeVida = 0;
            return animalVendido;
        }

        public int ValorTotal()
        {
            return PrecioAnimal + (Vender() * ProductoFinal);
        }
    }
}
