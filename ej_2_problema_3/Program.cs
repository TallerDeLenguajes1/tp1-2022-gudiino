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
                Console.WriteLine("CALCULO DEL RENDIMIENTO DEL COMBUSTIBLE DEL AUTO POR KILOMETRO RECORRIDO");
                Console.WriteLine("Ingrese los kilometros recorridos");
                Console.Write("KM = ");
                kilometros=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de litros consumidos");
                Console.Write("LTS = ");
                litros_combustible=Convert.ToInt32(Console.ReadLine());
                double consumoXkilometro;
                consumoXkilometro=rendimiento(kilometros,litros_combustible);
                Console.WriteLine("Rendimiento [km/lts] = {0}", consumoXkilometro);
                Console.WriteLine("FIN CODIGO.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos igresado no valido o falla en el sistema");
                Console.WriteLine("MENSAJE EXCEPCION:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("FIN EXCEPCION.");
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