using DemoEmail.App.Models.Email;

namespace DemoEmail.App.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
