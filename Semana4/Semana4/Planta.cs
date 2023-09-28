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
            if (TiempoDeVida > 0)
            {
                TiempoDeVida--;
            }
        }

    }

}
