using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProjectPart2
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mm = new MailMessage("onetwo12shah@gmail.com", "onetwo12shah@gmail.com");
                mm.Subject = CommentTextBox.Text;
                mm.Body = "Name: " + FirstNameTextBox.Text + "<br /><br />Email: " + EmailTextBox.Text + "<br />" + ContactTextBox.Text;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = "onetwo12shah@gmail.com";
                NetworkCred.Password = "VANDIT189";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
             }
            catch (Exception) { }
        }
       
    }
}