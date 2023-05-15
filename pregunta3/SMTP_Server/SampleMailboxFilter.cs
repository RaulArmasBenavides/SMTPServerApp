using SmtpServer;
using SmtpServer.Mail;
using SmtpServer.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pregunta3.SMTP_Server
{
    public class SampleMailboxFilter : IMailboxFilter, IMailboxFilterFactory
    {
        public Task<MailboxFilterResult> CanAcceptFromAsync(ISessionContext context, IMailbox @from, int size, CancellationToken cancellationToken)
        {
          
            if (String.Equals(@from.Host, "bw2.com"))
            {
                Console.WriteLine("El correo remitente es bw2.com ACEPTADO");
                return Task.FromResult(MailboxFilterResult.Yes);
            }

            return Task.FromResult(MailboxFilterResult.NoPermanently);
        }

        public Task<MailboxFilterResult> CanDeliverToAsync(ISessionContext context, IMailbox to, IMailbox @from, CancellationToken token)
        {
 
            if (String.Equals(to.Host, "bw2.com"))
            {
                Console.WriteLine("El correo destinatario es bw2.com ACEPTADO");
                return Task.FromResult(MailboxFilterResult.Yes);
            }
            return Task.FromResult(MailboxFilterResult.Yes);
        }

        public IMailboxFilter CreateInstance(ISessionContext context)
        {
            Console.WriteLine("CreateInstance Method");
            return new SampleMailboxFilter();
        }
    }
}
