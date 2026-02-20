using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    [Route("Email")]
    public class EmailController : Controller
    {
        [HttpPost("SentMail")]
        public IActionResult SentMail([FromBody] ContactRequest request)
        {
            try
            {
                var fromAddress = new MailAddress("sprabhakaran311@gmail.com", "Portfolio contacts");
                var toAddress = new MailAddress("prabhakarandotnetdeveloper@gmail.com");
                const string fromPassword = "eafk rgrd rcvn tifz";
                string subject = "New Contact Submission Portfolio";

                string body = $@"
                <h3>Contact Submission</h3>
                <p><strong>Name:</strong> {request.Name}</p>
                <p><strong>Email:</strong> {request.Email}</p>
                <p><strong>Mobile:</strong> {request.MobileNo}</p>
                <p><strong>Subject:</strong> {request.Subject}</p>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                }

                return Ok(new { success = true, message = "Email sent successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "Error sending email.", error = ex.Message });
            }
        }
    }
}
