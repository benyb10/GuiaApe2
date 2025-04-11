using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoAPE2
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=lrh5MKNZihQ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                // Dirección de correo a la que se enviarán las quejas
                string emailAddress = "jsoria8559@uta.edu.ec.com";

                // Asunto predefinido del correo
                string subject = "Queja sobre la aplicación";

                // Cuerpo del mensaje con algunas instrucciones
                string body = "Por favor, describa detalladamente su queja o problema con la aplicación:";

                // Construir la URI mailto con los parámetros
                string mailtoUri = $"mailto:{emailAddress}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

                // Abrir el cliente de correo predeterminado
                System.Diagnostics.Process.Start(mailtoUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el cliente de correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            try
            {
                // Reemplaza esta URL con la de tu repositorio de GitHub
                string githubUrl = "https://github.com/tu-usuario/tu-repositorio";

                System.Diagnostics.Process.Start(githubUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir GitHub: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Opción 1: Cierra toda la aplicación
            Application.Exit();

            // O, Opción 2: Cierra solo el formulario actual
            // this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGitHub_Click_1(object sender, EventArgs e)
        {
            // URL del repositorio en GitHub
            string url = "https://github.com/TheBearForce/proyectoAPE2";

            try
            {
                // Intentar abrir el enlace en el navegador predeterminado
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            // URL de soporte de Microsoft
            string url = "https://support.microsoft.com/es-es/office/cómo-iniciar-sesión-en-hotmail-c378938b-c0eb-40c1-b99e-338dd9e776a8";

            try
            {
                // Abrir la URL en el navegador predeterminado
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void btnYoutube_Click_1(object sender, EventArgs e)
        {
            // URL de YouTube
            string url = "https://www.youtube.com/watch?v=hfF9tOKEpFg";

            try
            {
                // Abrir la URL en el navegador predeterminado
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }
    }
}
