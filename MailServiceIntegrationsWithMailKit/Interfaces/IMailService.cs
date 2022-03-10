using MailServiceIntegrationsWithMailKit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailServiceIntegrationsWithMailKit.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest request);
        Task SendWelcomeEmailAsync(WelcomeRequest request);
    }
}
