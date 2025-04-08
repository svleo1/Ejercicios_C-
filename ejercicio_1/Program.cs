
/*Cargar sueldo por hora y horas trabajadas para calcular el salario de un operario*/

using System;

namespace ejercicio_1
{
    class Program
    {
        public static void Main(string[]args)
        {
            /*Definir variables*/
            int horas;
            float sueldoPorHora;
            string linea;

            /*Cargar datos*/
            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            linea = Console.ReadLine();
            horas = int.Parse(linea);

            Console.WriteLine("Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            sueldoPorHora = float.Parse(linea);

            /*Mostrar resaultado*/
            Console.WriteLine("El salario del operario es: ");
            Console.Write(horas * sueldoPorHora);
            Console.ReadKey();

        }
    }
} 
        