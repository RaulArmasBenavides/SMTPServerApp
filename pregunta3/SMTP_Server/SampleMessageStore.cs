using SmtpServer;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pregunta3.SMTP_Server
{
    public class SampleMessageStore : MessageStore  
    {

        public override Task<SmtpResponse> SaveAsync(ISessionContext context, IMessageTransaction transaction, CancellationToken cancellationToken)
        {
            string _saveFolderPath = "C:\\LOGS";
            // Crear un nombre de archivo único para el correo electrónico recibido
            var fileName = $"{Guid.NewGuid()}.txt";

            // Guardar el contenido del mensaje como archivo de texto
            using (var writer = new StreamWriter(Path.Combine(_saveFolderPath, fileName)))
            {
                writer.Write(transaction.Message);
                //await writer.WriteAsync(message.TextBody);
            }
            Console.WriteLine("Saving mail message");
            return Task<SmtpResponse>.FromResult(SmtpResponse.Ok);
            //throw new NotImplementedException();
        }
    }
}
