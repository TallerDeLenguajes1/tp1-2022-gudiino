using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            GetProvinciasArgentinas();
            Console.WriteLine("FIN CODIGO.");
        }
        private static void GetProvinciasArgentinas()
        {
            var url = @"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ProvinciasArgentina? ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            Console.WriteLine("NOMBRE PROVINCIA                                       ID PROVINCIA");
                            foreach (Provincia Prov in ListProvincias!.Provincias!)
                            {
                                Console.Write(Prov.Nombre);
                                int espacio=Prov.Nombre!.Count();
                                int espacio_final=55-espacio;
                                for (int i = 0; i < espacio_final; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(Prov.Id);
                                Console.WriteLine();
                                //Console.WriteLine("Provincia: " + Prov.Nombre + " Id: " + Prov.Id);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falla en el sistema o conexion con el API");
                Console.WriteLine("MENSAJE EXCEPCION:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("FIN EXCEPCION");
            }
        }
    }
}