using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalIdentidad
    {
        public List<Muestra> Muestras { get; set; }

        public SeñalIdentidad()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            resultado = tiempo;

            return resultado;
        }
    }
}
