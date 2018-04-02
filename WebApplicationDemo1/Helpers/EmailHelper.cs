using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SendGrid;
using SendGrid.Helpers.Mail;
using WebApplicationDemo1.ViewModel;

namespace WebApplicationDemo1.Helpers
{
    public class EmailHelper:IDisposable
    {
        public async Task SendEmailAsync(Contacts contact, string recipient)
        {
            try
            {
                ////var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
                //string API_KEY = ConfigurationManager.AppSettings["SENDGRID_APIKEY"];
                //var client = new SendGridClient(API_KEY);

                //var msg = new SendGridMessage()
                //{
                //    From = new EmailAddress(contact.Email),
                //    Subject = contact.Subject,
                //    HtmlContent = String.Format("<h4>{0}</h4><h4>{1}</h4><p>{2}</p>", contact.Name, contact.Email, contact.Message)
                //};

                //msg.AddTo(new EmailAddress(recipient));

                //var response = await client.SendEmailAsync(msg);
            }
            catch (Exception)
            {
                //ViewBag.Status = "Problem while sending email, Please check details.";

            }
        }

        public void Dispose()
        {

        }
    }
}