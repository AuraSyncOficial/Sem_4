using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    class Program
    {
        static void Main()
        {
            Granja miGranja = new Granja();
            int dineroInicial;

            Console.WriteLine("Bienvenido a este simulador para crear tu propia granja");
            Console.Write("Por favor, introduce con cuánto dinero quisieras comenzar: ");

            while (!int.TryParse(Console.ReadLine(), out dineroInicial))
            {
                Console.WriteLine("Por favor, ingresa una cantidad válida de dinero inicial:");
            }

            miGranja.DineroDisponible = dineroInicial;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Comenzarás con " + miGranja.DineroDisponible + " de dinero.");
                Console.WriteLine($"Tu granja tiene " + miGranja.Tamaño + " parcelas.");

                Console.WriteLine("¿Qué quisieras hacer ahora?");
                Console.WriteLine("1. Comprar más parcelas para la granja");
                Console.WriteLine("2. Comprar animales");
                Console.WriteLine("3. Comprar semillas");
                Console.WriteLine("4. Ver estado de los animales o semillas");
                Console.WriteLine("5. Pasar de día");
                Console.WriteLine("6. Cosechar");
                Console.WriteLine("7. Salir");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Entrada no válida. Por favor, elige una opción válida.");
                }

                switch (opcion)
                {
                    case 1:
                        miGranja.ComprarExpansion();
                        break;
                    case 2:
                        MostrarAnimalesDisponibles();
                        int seleccion;
                        if (int.TryParse(Console.ReadLine(), out seleccion))
                        {
                            ComprarAnimal(seleccion, miGranja);
                        }
                        break;
                    case 3:
                        MostrarPlantasDisponibles();
                        int seleccio;
                        if (int.TryParse(Console.ReadLine(), out seleccio))
                        {
                            ComprarPlanta(seleccio, miGranja);
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingresa una opción válida.");
                        }
                        break;
                    case 4:
                        MostrarEstado(miGranja);
                        Console.ReadLine();
                        break;
                    case 5:
                        PasarDia(miGranja);
                        Console.WriteLine("Ha pasado un día.");
                        Console.ReadLine();
                        break;
                    case 6:
                        CosecharPlantas(miGranja);
                        ProductosAnimales(miGranja);
                        Console.ReadLine();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }

            void MostrarPlantasDisponibles()
            {
                Console.WriteLine("Plantas disponibles para comprar:");
                Console.WriteLine("0. Cereza - Precio: 20");
                Console.WriteLine("1. Frambuesa - Precio: 40");
                Console.WriteLine("2. Fresa - Precio: 10");
                Console.WriteLine("3. Mora - Precio: 50");
            }
            void MostrarAnimalesDisponibles()
            {
                Console.WriteLine("Animales disponibles para comprar:");
                Console.WriteLine("0. Pato - Precio: 100");
                Console.WriteLine("1. Cerdo - Precio: 150");
                Console.WriteLine("2. Vaca - Precio: 300");
                Console.WriteLine("3. Gallina - Precio: 200");
            }

            void ComprarPlanta(int seleccion, Granja granja)
            {
                if (granja.ParcelasDisponibles <= 0)
                {
                    Console.WriteLine("No tienes suficiente espacio. Debes comprar más parcelas.");
                    Console.ReadLine();
                    return;
                }
                switch (seleccion)
                {
                    case 0:
                        if (granja.DineroDisponible >= 20)
                        {
                            granja.DineroDisponible -= 20;
                            Planta cereza = new Planta("Cereza", 2, 3, 20, 40);
                            miGranja.plantasLista.Add(cereza);
                            Console.WriteLine("Has comprado una Cereza.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Cereza.");
                            Console.ReadLine();
                        }
                        break;
                    case 1:
                        if (granja.DineroDisponible >= 40)
                        {
                            granja.DineroDisponible -= 40;
                            Planta frambuesa = new Planta("Frambuesa", 3, 6, 40, 80);
                            miGranja.plantasLista.Add(frambuesa);
                            Console.WriteLine("Has comprado una Frambuesa.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Frambuesa.");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (granja.DineroDisponible >= 10)
                        {
                            granja.DineroDisponible -= 10;
                            Planta fresa = new Planta("Fresa", 1, 1, 10, 20);
                            miGranja.plantasLista.Add(fresa);
                            Console.WriteLine("Has comprado una Fresa.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Fresa.");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (granja.DineroDisponible >= 50)
                        {
                            granja.DineroDisponible -= 50;
                            Planta mora = new Planta("Cereza", 7, 15, 50, 200);
                            miGranja.plantasLista.Add(mora);
                            Console.WriteLine("Has comprado una Mora.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Mora.");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Por favor, selecciona una opción válida.");
                        Console.ReadLine();
                        break;
                }
            }

            void ComprarAnimal(int seleccion, Granja granja)
            {
                if (granja.ParcelasDisponibles <= 0)
                {
                    Console.WriteLine("No tienes suficiente espacio. Debes comprar más parcelas.");
                    Console.ReadLine();
                    return;
                }
                switch (seleccion)
                {
                    case 0:
                        if (granja.DineroDisponible >= 100)
                        {
                            granja.DineroDisponible -= 100;
                            Animales Pato = new Animales("Pato", 3, 1, 100, 30);
                            miGranja.animalesLista.Add(Pato);
                            Console.WriteLine("Has comprado un Pato.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar un Pato.");
                            Console.ReadLine();
                        }
                        break;
                    case 1:
                        if (granja.DineroDisponible >= 150)
                        {
                            granja.DineroDisponible -= 150;
                            Animales Cerdo = new Animales("Cerdo", 10, 3, 150, 90);
                            miGranja.animalesLista.Add(Cerdo);
                            Console.WriteLine("Has comprado un Cerdo.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar un Cerdo.");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (granja.DineroDisponible >= 300)
                        {
                            granja.DineroDisponible -= 300;
                            Animales Vaca = new Animales("Vaca", 5, 5, 300, 80);
                            miGranja.animalesLista.Add(Vaca);
                            Console.WriteLine("Has comprado una Vaca.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Vaca.");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (granja.DineroDisponible >= 200)
                        {
                            granja.DineroDisponible -= 200;
                            Animales Gallina = new Animales("Gallina", 8, 12, 200, 50);
                            miGranja.animalesLista.Add(Gallina);
                            Console.WriteLine("Has comprado una Gallina.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente dinero para comprar una Gallina.");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Por favor, selecciona una opción válida.");
                        Console.ReadLine();
                        break;
                }
            }

            void MostrarEstado(Granja granja)
            {
                Console.WriteLine("Estado de tu granja:");

                foreach (Planta planta in granja.plantasLista)
                {
                    Console.WriteLine($"Nombre: {planta.Nombre}");
                    Console.WriteLine($"Tiempo de Vida Restante: {planta.TiempoDeVida}");
                    if (planta.TiempoDeVida == 0)
                    {
                        Console.WriteLine($"¡Puedes cosechar esta planta!");
                    }
                    else
                    {
                        Console.WriteLine("No puedes cosechar esta planta aún.");
                    }
                    Console.WriteLine();
                }
                foreach (Animales animales in granja.animalesLista)
                {
                    Console.WriteLine($"Nombre: {animales.Nombre}");
                    Console.WriteLine($"Tiempo de producto restante: {animales.TiempoDeVida}");
                    if (animales.TiempoDeVida == 0)
                    {
                        Console.WriteLine($"¡Puedes obtener productos");
                    }
                    else
                    {
                        Console.WriteLine("No puedes obtener productos aún.");
                    }
                    Console.WriteLine();
                }
            }

            void PasarDia(Granja granja)
            {
                foreach (Planta planta in granja.plantasLista)
                {
                    planta.Crecer();
                }
                foreach (Animales animales in granja.animalesLista)
                {
                    animales.Crecer();
                }
            }

            void CosecharPlantas(Granja granja)
            {
                if (granja.plantasLista.Count == 0 || !granja.plantasLista.Any(planta => planta.TiempoDeVida == 0))
                {
                    Console.WriteLine("No hay plantas disponibles para cosechar en este momento.");
                    return;
                }
                foreach (Planta planta in granja.plantasLista.ToList())
                {
                    if (planta.TiempoDeVida == 0)
                    {
                        granja.DineroDisponible += planta.ValorProducto;
                        Console.WriteLine($"Has cosechado una {planta.Nombre}. Ganaste {planta.ValorProducto} de dinero.");
                        granja.plantasLista.Remove(planta);
                    }
                }
            }
            void ProductosAnimales(Granja granja)
            {
                foreach (Animales animales in granja.animalesLista)
                {
                    if (animales.TiempoDeVida == 0)
                    {
                        granja.DineroDisponible += animales.ProductoFinal;
                        Console.WriteLine($"Has obtenido un producto de {animales.Nombre}. Ganaste {animales.ProductoFinal} de dinero.");
                        animales.RestaurarTiempoDeVidaInicial();
                    }
                }
            }
        }
    }

}
