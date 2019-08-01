using System;

namespace ServicioWeb.Shared
{
    public static class Utiles
    {
        public static bool ValidacionDatos(string cadena)
        {
            var correcto = false;
            if (cadena.Contains(",") && cadena.Length > 3)
            {
                string[] datos = DividirDatos(cadena);
                if (datos[0].Length > 3 && datos[1].Length > 3)
                {
                    correcto = true;
                }
            }

            return correcto;
        }

        private static string[] DividirDatos(string cadena)
        {
            return cadena.Split(',');
        }

        public static string TransformarDatos(string cadena)
        {
            string[] datos = DividirDatos(cadena);
            var frase = $"Rebeld " + datos[0] + " on " + datos[1] + " at " + DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");

            return frase;
        }
    }
}