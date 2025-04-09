/*Uso de condicionales basicos: ingresar un numero positivo de uno o dos digitos, mostrar si el numero es de uno o dos digitos*/

using System;

namespace ejercio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Definir variables*/
            int numeroIngresado;
            string linea;

            /*Ingresar numero y almacenar*/
            Console.WriteLine("Ingrese un numero positivo de uno o dos digitos:");
            linea = Console.ReadLine();
            numeroIngresado = int.Parse(linea);

            /*Filtrar y mostrar*/
            if (numeroIngresado <= 0 || numeroIngresado > 99)
            {
                Console.WriteLine("El numero debe ser mayor a 0");
            }
            else if (numeroIngresado < 10)
            {
                Console.WriteLine("El numero tiene un digito");
            }
            else
            {
                Console.WriteLine("El numero tiene dos digitos");
            }
            Console.WriteLine("Presione cualquier tecla para cerrar");
            Console.ReadKey();
        }   
    }
}
