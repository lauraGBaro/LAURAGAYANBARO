using System.Web.Services;
using ServicioWeb.Modelo;

namespace ServicioWeb
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ServicioWebGalaxia : WebService
    {

        [WebMethod]
        public bool LecturaDeRegistro(string cadena)
        {
            var correcto = false;

            if (Shared.Utiles.ValidacionDatos(cadena))
            {
                var fraseRegistro = Shared.Utiles.TransformarDatos(cadena);
                correcto = Fichero.Instance().RegistroFichero(fraseRegistro);
            }

            return correcto;
        }

    }
}
