using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    class Granja
    {
        private int tamaño;
        private int dineroDisponible;
        private List<string> plantasAnimales;

        public int Tamaño => tamaño;
        public int DineroDisponible => dineroDisponible;
        public int NumeroDePlantasAnimales => plantasAnimales.Count;

        public Granja()
        {
            tamaño = 1;
            dineroDisponible = 100;
            plantasAnimales = new List<string>();
        }

        public void ComprarExpansion()
        {
            int costo = tamaño * 10;
            if (dineroDisponible >= costo)
            {
                dineroDisponible -= costo;
                tamaño++;
                Console.WriteLine($"¡Has expandido tu granja! Nuevo tamaño: {tamaño}");
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero para expandir la granja.");
            }
            Console.ReadLine();
        }

        public void AgregarPlantaOAnimal()
        {
            Console.Write("Ingrese el nombre de la planta o animal: ");
            string nombre = Console.ReadLine();
            plantasAnimales.Add(nombre);
            Console.WriteLine($"Has agregado un/a {nombre} a tu granja.");
            Console.ReadLine();
        }
    }
}
