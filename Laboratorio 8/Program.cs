using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos de su Grupo de Evaluacion");
            Console.Write("Nombre");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la nota inicial: ");
            double notaInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la cantidad maxima de notas: ");
            int cantidadMaximaNotas = Convert.ToInt32(Console.ReadLine());
            GrupoEvaluacion grupoEvaluacion = new GrupoEvaluacion(nombre,notaInicial, cantidadMaximaNotas);
            ObservadorDePromedio observador = new ObservadorDePromedio();
            grupoEvaluacion.onPromedioAzul = observador.NotificarPromedioAzul;
            grupoEvaluacion.onPromedioRojo = observador.NotificarPromedioAzul;
            grupoEvaluacion.onVariacionPromedio = observador.NotificarCambioPromedio;
            Console.WriteLine("Ingrese las notas de su grupo de evaluacion. Ingrese 0 si desea terminar");
            double nota = -1;
            while (nota != 0 || grupoEvaluacion.notas.Count != grupoEvaluacion.cantidadMaximaNotas)
            {
                Console.Write("Ingrese nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                grupoEvaluacion.AgregarNota(nota);
                
            }

            

        }
    }
}
