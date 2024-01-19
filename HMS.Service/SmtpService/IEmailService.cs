namespace HMS.Service.SmtpService
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(EmailMessage email);
    }
}
