using HJR.Email.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace HJR.Email
{
    public sealed class SendGridSender : IEmailSender
    {
        private readonly SmtpSettings _smtpSettings;

        public SendGridSender(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(_smtpSettings.Password);
            var from = new EmailAddress(_smtpSettings.SentFrom);
            var to = new EmailAddress(email);

            var msg = MailHelper.CreateSingleEmail(from, to, subject, string.Empty, htmlMessage);

            return client.SendEmailAsync(msg);
        }
    }
}
