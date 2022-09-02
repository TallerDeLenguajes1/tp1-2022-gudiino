using System;
using System.Diagnostics;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionLlamadoraA();
            FuncionLlamadoraB();
            // Console.WriteLine("Ingrese un número entero");
            // /*se ingresa como prueba un numero grande y letras*/
            // Console.Write("número = ");
            // string a=Console.ReadLine();
            // try
            // {
            //     double cuadrado;
            //     cuadrado=Cuadrado(a);
            //     Console.WriteLine("cuadrado del número = {0}", cuadrado);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("falla usando --> throw");
            //     throw;
            // }
            
        }
        public static void FuncionLlamadoraA()
        {
            Dividir(3,3);
        }
        public static void FuncionLlamadoraB()
        {
            Dividir(3,0);
        }
        public static void Dividir(int a, int b)
        {
            try
            {
                int c=a/b;
            }
            catch (Exception ex)
            {
                throw;
            } 
        }
    }
}