using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public delegate void VariacionPromedio(double promedioAnterior, double promedioNuevo, int cantidadMaximaNotas, int cantidadActualNotas); 
    class GrupoEvaluacion
    {
        public List<double> notas { get; private set; }
        string nombre;
        double promedio;
        public int cantidadMaximaNotas { get; private set; }
        public VariacionPromedio onPromedioRojo, onPromedioAzul, onVariacionPromedio;
        public GrupoEvaluacion(string nombre, double notaInicial, int cantidadMaximaNotas)
        {
            notas = new List<double>();
            this.nombre = nombre;
            notas.Add(notaInicial);
            this.cantidadMaximaNotas = cantidadMaximaNotas;
            promedio = notaInicial;
        }

        private double CalcularPromedio()
        {
            double suma = 0.0;
            foreach(double n in notas)
            {
                suma += n;
            }
            return (suma / notas.Count);
        }

        public bool AgregarNota(double nota)
        {
            if (notas.Count >= this.cantidadMaximaNotas)
            {
                return false;
            }
            notas.Add(nota);
            double promedio = CalcularPromedio();
            if (promedio < 4 && this.promedio>=4)
            {
                onPromedioRojo(this.promedio, promedio, this.cantidadMaximaNotas, notas.Count);
            }
            else if(promedio>=4 && this.promedio < 4)
            {
                onPromedioAzul(this.promedio, promedio, this.cantidadMaximaNotas, notas.Count);
            }
            else
            {
                onVariacionPromedio(this.promedio, promedio, this.cantidadMaximaNotas, notas.Count);
            }
            this.promedio = CalcularPromedio();
            return true;
        }

    }
}
