using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2;//solicitud de carga de enteros para generar excepcion en division
                Console.WriteLine("Ingrese dos números");
                //se ingresa como prueba un numero grande, letras, numero 0 como divisor, numero decimal
                Console.Write("Número 1 = ");
                num1=Convert.ToInt32(Console.ReadLine());
                Console.Write("Número 2 = ");
                num2=Convert.ToInt32(Console.ReadLine());
                double division=num1/num2;
                Console.WriteLine("Division de los números = {0}", division);
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