using System;
using System.IO;

namespace ServicioWeb.Modelo
{
    public class Fichero
    {
        private static Fichero _instance = new Fichero();
        private static readonly object Lock = new object();
        private static string _rutaFichero = "registro.txt";

        public static Fichero Instance()
        {
            if(_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null) _instance = new Fichero();
                }
            }

            return _instance;
        }
    


        public bool RegistroFichero(string cadena)
        {
            var respuesta = false;
            try
            {
                if (File.Exists(_rutaFichero))
                {
                    File.OpenText(_rutaFichero);
                }

                using (StreamWriter writer = File.AppendText(_rutaFichero))
                {
                    writer.WriteLine(cadena);
                }

                respuesta = true;
            }
            catch (Exception ex)
            {
                Log.Instance().Error(ex.Message);
            }

            return respuesta;
        }
    }
}