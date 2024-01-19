namespace HMS.Service.SmtpService
{
    public class EmailMessage
    {
        public string ReceiversEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
    }
}
