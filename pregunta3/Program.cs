using Microsoft.Extensions.DependencyInjection;
using pregunta3.SMTP_Server;
using SmtpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new SmtpServerOptionsBuilder()
              .ServerName("localhost")
              .Port(25, 587)
              .MessageStore(new SampleMessageStore())
              .MailboxFilter(new SampleMailboxFilter())
              .UserAuthenticator(new SampleUserAuthenticator())
              .Build();

            // Crear un objeto ServiceCollection
            //var services = new ServiceCollection();

            SmtpServer.SmtpServer smtpServer = new SmtpServer.SmtpServer(options);
            // Iniciamos el servidor SMTP
            smtpServer.StartAsync(CancellationToken.None);

            Console.WriteLine("Servidor SMTP iniciado. Presione cualquier tecla para detener...");
            Console.ReadKey();

            // Detenemos el servidor SMTP
            


        }
    }
}
