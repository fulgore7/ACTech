using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Email;
using Aspose.Email.Clients.Smtp;
using Aspose.Email.Mime;
using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;

namespace ACTech.Services
{
    public class EmailService
    {
        public void CreateEmail(string filename)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            // Set username, Password, Port No, and SecurityOptions
            client.Username = "user@gmail.com";
            client.Password = "your.password";
            client.Port = 587;
            // Create new message and save as EML
            MailMessage message = new MailMessage("from@domain.com", "to@domain.com");
            message.Subject = "subject of email";
            message.HtmlBody = "<b>Eml to msg conversion using Aspose.Email</b>" +
                "<br><hr><br><font color=blue>This is a test eml file which will be converted to msg format.</font>";
            // Add attachments
            message.Attachments.Add(new Attachment(filename));
            
            
        }
    }
}
