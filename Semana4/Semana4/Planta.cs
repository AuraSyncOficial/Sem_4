using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    class Planta
    {
        public string Nombre { get; }
        public int TiempoDeVida { get; private set; }
        public int FrutosVerdurasPorCosecha { get; }
        public int ValorSemilla { get; }
        public int ValorProducto { get; }

        public Planta(string nombre, int tiempoDeVida, int frutosVerdurasPorCosecha, int valorSemilla, int valorProducto)
        {
            Nombre = nombre;
            TiempoDeVida = tiempoDeVida;
            FrutosVerdurasPorCosecha = frutosVerdurasPorCosecha;
            ValorSemilla = valorSemilla;
            ValorProducto = valorProducto;
        }

        public void Crecer()
        {
            TiempoDeVida++;
        }

        public int Cosechar()
        {
            int productosCosechados = FrutosVerdurasPorCosecha;
            TiempoDeVida = 0;
            return productosCosechados;
        }

        public int ValorTotal()
        {
            return ValorSemilla + (Cosechar() * ValorProducto);
        }
    }
}
