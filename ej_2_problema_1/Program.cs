using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1;
                Console.WriteLine("Ingrese un número entero");
                num1=Convert.ToInt32(Console.ReadLine());//se ingresa como prueba un numero grande
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
                Console.WriteLine("FIN.");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Datos igresado no valido o falla en el sistema");
                Console.WriteLine("FIN.");
            }   
        }
    }
}