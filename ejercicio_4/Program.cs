/*Uso de condicionales y operadores logicos: De un operario se conoce su sueldo y los años de antigüedad.
Se pide confeccionar un programa que lea los datos de entrada e informe:
a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años,
otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios */

using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*Definir variables*/
            int antiguedad;
            float sueldo;
            string linea;

            /*Cargar variables*/
            Console.WriteLine("Ingrese la antiguedad (en años) del operario (debe ser menor a 50)");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);

            Console.WriteLine("Ingrese el sueldo del operario");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);

            /*Descartar entradas incorrectas*/
            if (antiguedad <= 0 || antiguedad > 50 || sueldo < 100)
            {
                Console.WriteLine("Los datos ingresados no son validos");
            }
            /*Filtrar entradas correctas*/
            else if (sueldo > 500)
            {
                Console.Write("El salario del operario es: ");
                Console.WriteLine(sueldo);
            }
            else if (sueldo < 500 && antiguedad >= 10)
            {
                Console.WriteLine("El operador recibira un aumento del 20 por ciento");
                Console.Write("Nuevo sueldo: ");
                Console.WriteLine(sueldo * 1.20);
            }
            else
            {
                Console.WriteLine("El operador recibira un aumento del 5 por ciento");
                Console.Write("Nuevo sueldo: ");
                Console.WriteLine(sueldo * 1.05);
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}