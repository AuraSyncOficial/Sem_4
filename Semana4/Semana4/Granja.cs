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
        public List<Planta> plantasLista;
        public List<Animales> animalesLista;

        public int Tamaño => tamaño;
        public int DineroDisponible
        {
            get { return dineroDisponible; }
            set { dineroDisponible = value; }
        }
        public int ParcelasDisponibles => Tamaño - (plantasLista.Count+ animalesLista.Count);
        public Granja()
        {
            tamaño = 1;
            dineroDisponible = 100;
            plantasLista = new List<Planta>();
            animalesLista = new List<Animales>();
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

    }

}
