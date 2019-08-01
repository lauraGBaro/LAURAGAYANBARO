using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicioWeb.Modelo;

namespace ClienteImperio
{
    public partial class Form1 : Form
    {
        private const string Correcto = "El registro se ha completado con éxito";
        private const string Fallido = "El registro ha fallado";
        private const string VacioRebelde = "El nombre del rebelde no puede estar vacío o contener caracteres especiales";
        private const string VacioPlaneta = "El nombre del planeta no puede estar vacío o contener caracteres especiales";
        private const string VacioError = "Intento de creación con campos vacíos o con caracteres especiales";

        public Form1()
        {
            InitializeComponent();
        }

        private void Boton1Click(object sender, EventArgs e)
        {
            List<string> datos = new List<string>();
            datos.Add(textBoxNombre.Text);
            datos.Add(textBoxPlaneta.Text);

            var respuesta = ControlErrores(Shared.Utiles.ValidacionEntradaDatos(datos));

            if (respuesta)
            {
                using (var servicio = new ServicioWeb.ServicioWebGalaxia())
                {
                    respuesta = servicio.LecturaDeRegistro(textBoxNombre.Text + "," + textBoxPlaneta.Text);
                    var textoRespuesta = respuesta ? Correcto : Fallido;
                    textBoxInfo.Text = textoRespuesta;
                    Log.Instance().Info(textoRespuesta);
                }
            }
        }


        private bool ControlErrores(List<bool> errores)
        {
            var respuesta = true;
            if (errores[0])
            {
                errorProvider1.SetError(textBoxNombre, VacioRebelde);
            }

            if (errores[1])
            {
                errorProvider2.SetError(textBoxNombre, VacioPlaneta);
            }

            if (errores.Contains(true))
            {
                Log.Instance().Error(VacioError);
                respuesta = false;
            }

            return respuesta;
        }

    }
}
