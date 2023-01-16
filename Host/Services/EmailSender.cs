using Microsoft.AspNetCore.Identity.UI.Services;

namespace IdentityServer4.Host.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            //TODO: USE MANDRILL
            return Task.CompletedTask;
        }
        
    }
}
