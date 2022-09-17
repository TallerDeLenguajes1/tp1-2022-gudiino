using System;

namespace Problema03
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar=0;
            while(continuar==0){
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
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n+++ ADVERTENCIA");
                    Console.WriteLine("Ingreso un valor INVALIDO, debe ingresar dos numeros ENTEROS");
                    Console.WriteLine("+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("\n+++ ADVERTENCIA");
                    Console.WriteLine("Ingreso un valor demasiado GRANDE, ingrese un valor menor a 2.147.483.647");
                    Console.WriteLine("+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n+++ ADVERTENCIA");
                    Console.WriteLine("Operacion no valida");
                    Console.WriteLine("\n+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("\nREINTENTAR");
                }
                Console.WriteLine("++++++++++++++++++++++++");//no aplica para verificacion de ingreso de datos
                Console.WriteLine("0-> Continuar");
                Console.WriteLine("1-> Finalizar");
                Console.Write("Seleccion: ");
                continuar=Convert.ToInt32(Console.ReadLine());
            }
        }
        private static double rendimiento(int distancia, int litros)
        {
            return distancia/litros;
        }
    }
}