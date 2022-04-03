using MimeKit;

namespace DemoEmail.App.Models.Email
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public Message(List<string> to, string subject, string content)
        {
            this.To = to.Select(receiver => new MailboxAddress(receiver)).ToList();
            this.Subject = subject;
            this.Content = content;
        }
    }
}
