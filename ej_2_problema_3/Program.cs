using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double kilometros, litros_combustible;
                Console.WriteLine("Ingrese los kilometros conducidos y la cantidad de litros consumidos");
                kilometros=Convert.ToInt64(Console.ReadLine());
                litros_combustible=Convert.ToInt64(Console.ReadLine());
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