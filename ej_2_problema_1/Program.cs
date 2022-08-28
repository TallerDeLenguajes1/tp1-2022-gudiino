using System;

namespace Problema01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1;
                Console.WriteLine("Ingrese un número entero");
                /*se ingresa como prueba un numero grande y letras*/
                Console.Write("número = ");
                num1=Convert.ToInt32(Console.ReadLine());
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
                Console.WriteLine("FIN PROGRAMA.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos igresado no valido o falla en el sistema");
                Console.WriteLine("MENSAJE EXCEPCION:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("FIN EXCEPCION.");
            }   
        }
    }
}