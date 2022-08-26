using System;

namespace Problema03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int kilometros, litros_combustible;//para generar excepacion
                Console.WriteLine("Ingrese los kilometros recorridos");
                kilometros=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de litros consumidos");
                litros_combustible=Convert.ToInt32(Console.ReadLine());
                double consumoXkilometro;
                consumoXkilometro=rendimiento(kilometros,litros_combustible);
                Console.WriteLine("Rendimiento [km/litro] = {0}", consumoXkilometro);
                Console.WriteLine("FIN CODIGO.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos igresado no valido o falla en el sistema");
                Console.WriteLine(ex.Message);
                Console.WriteLine("FIN FALLA.");
            }
            finally
            {
                Console.WriteLine("FIN PROGRAMA");
            }
        }
        private static double rendimiento(double distancia, double litros)
        {
            return distancia/litros;
        }
    }
}