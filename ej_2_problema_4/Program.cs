using System;
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
            
            //***************************************
            try
            {
                GetProvinciasArgentinas();
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
                            ProvinciasArgentina ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            foreach (Provincia Prov in ListProvincias.Provincias)
                            {
                                Console.WriteLine("Provincia: " + Prov.Nombre + " Id: " + Prov.Id);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
                Console.WriteLine("Falla");
                Console.WriteLine(ex.Message);
            }
        }
    }
}