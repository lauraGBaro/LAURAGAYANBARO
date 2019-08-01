using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClienteImperio.Shared
{
    public static class Utiles
    {

        public static List<bool> ValidacionEntradaDatos(List<string> datos)
        {
            List<bool> errores = new List<bool>();
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            
            foreach (var item in datos)
            {
                bool error = string.IsNullOrEmpty(item) || !regexItem.IsMatch(item);
                errores.Add(error);
            }

            return errores;
        }
    }
}
