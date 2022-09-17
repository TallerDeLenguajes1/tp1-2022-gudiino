using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar=0;
            while(continuar==0){
                try
                {
                    int num1, num2;//solicitud de carga de enteros para generar excepcion en division
                    Console.WriteLine("DIVISION entre enteros (numero 1 / numero 2)");
                    Console.WriteLine("Ingrese dos números enteros menor a 2.147.483.647 para la operacion");
                    //se ingresa como prueba un numero grande, letras, numero 0 como divisor, numero decimal
                    Console.Write("Número 1 = ");
                    num1=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Número 2 = ");
                    num2=Convert.ToInt32(Console.ReadLine());
                    double division=num1/num2;
                    Console.WriteLine("Division de los números = {0}", division);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ingreso un valor INVALIDO, debe ingresar dos numeros ENTEROS");
                    Console.WriteLine("+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Ingreso un valor demasiado GRANDE, ingrese un valor menor a 2.147.483.647");
                    Console.WriteLine("+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("OPERACION no valida");
                    Console.WriteLine("+++ MENSAJE EXCEPCION:");
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("++++++++++++++++++++++++");//no aplica para verificacion de ingreso de datos
                Console.WriteLine("0-> Reintentar");
                Console.WriteLine("1-> Finalizar");
                Console.Write("Seleccion: ");
                continuar=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nFIN PROGRAMA");   
        }
    }
}