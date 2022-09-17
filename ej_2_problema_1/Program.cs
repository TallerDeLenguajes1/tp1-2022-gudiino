using System;

namespace Problema01
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar=0;
            while(continuar==0){
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Datos igresado no valido o falla en el sistema");
                    Console.WriteLine("\n+++ MENSAJE EXCEPCION: ");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\n+++ MENSAJE SOURCE: ");
                    Console.WriteLine(ex.Source);
                    Console.WriteLine("\n+++ MENSAJE INNER EXCEPTION: ");
                    var msj="Error message: "+ex.Message;
                    if(ex.InnerException != null){
                        msj=msj+"Inner exception: "+ex.InnerException.Message;
                    }
                    Console.WriteLine(msj);
                    Console.WriteLine("\n+++ MENSAJE STACK TRACE: ");
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("\n+++ MENSAJE TARGET SITE: ");
                    Console.WriteLine(ex.TargetSite);
                    Console.WriteLine("\n+++ MENSAJE HELP LINK: ");
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine("\n+++ MENSAJE DATA: ");
                    Console.WriteLine(ex.Data);
                    Console.WriteLine("\n+++ LANZAR EXCEPCION THROW: ");
                    throw new Exception("==== Falla en ingreso de datos ====", ex);
                }
                finally{
                    Console.WriteLine("\n+++ FINALLY");
                }
                Console.WriteLine("++++++++++++++++++++++++");
                Console.WriteLine("0-> Continuar");
                Console.WriteLine("1-> Finalizar");
                Console.Write("Seleccion: ");
                continuar=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nFIN PROGRAMA"); 
        }
    }
}