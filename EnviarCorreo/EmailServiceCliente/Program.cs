using System;
using System.Net.Mail;
using System.Net.Mime;
using EmailService;

namespace EmailServiceCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GestorCorreo gestor = new GestorCorreo();

                //Correo con archivos adjuntos
                MailMessage correo = new MailMessage("cyndpantoja@gmail.com",
                                                     "harlanpereamartinez.hp@gmail.com",
                                                     "Archivo de configuracíon",
                                                     "Por favor verificar adjunto.");

                string ruta = "Configuracion.xml";
                Attachment adjunto = new Attachment(ruta, MediaTypeNames.Application.Xml);
                correo.Attachments.Add(adjunto);
                gestor.EnviarCorreo(correo);

                // Correo con HTML
                gestor.EnviarCorreo("cyndpantoja@gmail.com",
                                    "Prueba",
                                    "Mensaje en texto plano");
                // Correo de texto  
                gestor.EnviarCorreo("cyndpantoja@gmail.com",
                                    "Prueba",
                                    "<h1>Mensaje en HTML<h1><p>Contenido</p>",
                                    true);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
