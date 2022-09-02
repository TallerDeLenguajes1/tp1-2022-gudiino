using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero");
            /*se ingresa como prueba un numero grande y letras*/
            Console.Write("número = ");
            string a=Console.ReadLine();
            try
            {
                double cuadrado;
                cuadrado=Cuadrado(a);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("falla usando --> throw");
                throw;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            try
            {
                double cuadrado;
                cuadrado=Cuadrado1(a);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("falla usando --> throw new FormatException(Mensaje 1, ex)");
                throw new FormatException("Mensaje 1", ex);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            try
            {
                double cuadrado;
                cuadrado=Cuadrado2(a);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("falla usando --> throw new OverflowException(Mensaje 2)");
                throw new OverflowException("Mensaje 2");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            try
            {
                double cuadrado;
                cuadrado=Cuadrado3(a);
                Console.WriteLine("cuadrado del número = {0}", cuadrado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("falla usando --> throw ex");
                throw ex;
            }
            Console.WriteLine("FIN PROGRAMA."); 
        }
        public static double Cuadrado(string x)
        {
            try
            {
                int num1;
                num1=Convert.ToInt32(x);
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                return cuadrado;
            }
            catch (Exception ex)
            {
                throw;
            } 
        }
        public static double Cuadrado1(string x)
        {
            try
            {
                int num1;
                num1=Convert.ToInt32(x);
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                return cuadrado;
            }
            catch (Exception ex)
            {
                throw new FormatException("Error en el formato de dato ingresado", ex);
            } 
        }
        public static double Cuadrado2(string x)
        {
            try
            {
                int num1;
                num1=Convert.ToInt32(x);
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                return cuadrado;
            }
            catch (Exception ex)
            {
                throw new OverflowException("Error en el ingreso del tamaño de dato ingresado");
                throw ex;
                Console.WriteLine("FIN EXCEPCION.");
            } 
        }
        public static double Cuadrado3(string x)
        {
            try
            {
                int num1;
                num1=Convert.ToInt32(x);
                double cuadrado;
                cuadrado=Math.Pow(num1,2);
                return cuadrado;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}