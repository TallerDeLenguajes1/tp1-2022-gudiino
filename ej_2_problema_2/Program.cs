using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2;
                Console.WriteLine("Ingrese dos números enteros");
                num1=Convert.ToInt32(Console.ReadLine());
                num2=Convert.ToInt32(Console.ReadLine());//se ingresa como prueba un numero grande
                double division=num1/num2;
                Console.WriteLine("Division de los números = {0}", division);
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