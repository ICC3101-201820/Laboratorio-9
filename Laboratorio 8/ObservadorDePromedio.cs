using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    class ObservadorDePromedio
    {
        public ObservadorDePromedio() { }
        public void NotificarPromedioRojo(double promedioAnterior, double promedioActual, int cantidadMaximaNotas, int cantidadActualNotas)
        {
            Console.WriteLine("Tu promedio bajó, ahora es rojo D:");
            double sumaActual = promedioActual / cantidadActualNotas;
            double sumaFutura = 4 * cantidadMaximaNotas - sumaActual;
            Console.WriteLine("Las notas que debes sacarte para terminar con promedio azul son: ");
            int notasRestantes = cantidadMaximaNotas - cantidadActualNotas;
            for (int i = 0; i<notasRestantes; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {sumaFutura / notasRestantes}");
            }
        }
        public void NotificarPromedioAzul(double promedioAnterior, double promedioActual, int cantidadMaximaNotas, int cantidadActualNotas)
        {
            Console.WriteLine("Tu promedio subió, ahora es azul :D");
            double sumaActual = promedioActual / cantidadActualNotas;
            double sumaFutura = 4 * cantidadMaximaNotas - sumaActual;
            Console.WriteLine("Las notas que debes sacarte para mantener un promedio azul son: ");
            int notasRestantes = cantidadMaximaNotas - cantidadActualNotas;
            for (int i = 0; i < notasRestantes; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {sumaFutura / notasRestantes}");
            }
        }
        public void NotificarCambioPromedio(double promedioAnterior, double promedioActual, int cantidadMaximaNotas, int cantidadActualNotas)
        {
            Console.WriteLine($"Tu promedio pasó de un {promedioAnterior} a un {promedioActual}");
        }
    }
}
