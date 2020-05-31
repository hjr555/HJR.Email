namespace HJR.Email.Configuration
{
    public class SmtpSettings
    {
        /// <summary>
        /// The address of the SMTP server
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// The Port for the SMTP server
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// The Username required for authenticating against the SMTP server
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The Password required for authenticating against the SMTP server
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The email address to be displayed in the 'sent from' field for the recipient
        /// </summary>
        public string SentFrom { get; set; }
    }
}