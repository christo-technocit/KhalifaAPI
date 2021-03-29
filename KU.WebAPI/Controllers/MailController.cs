using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;

using MailKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using KU.Services.ViewModels;
using MimeKit.Text;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using KU.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace KU.WebAPI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    [EnableCors("MyPolicy")]
    public class MailController : Controller
    {

        //public MailController(SmtpClient smtpClient)
        //{
        //    this.smtpClient = smtpClient;

        //}
        IConfiguration Configuration;
        private readonly IUserService UserService;
        readonly ILogger logger;
        public MailController(IConfiguration configuration, IUserService UserService, ILogger<UsersController> logger)
        {
            Configuration = configuration;
            this.UserService = UserService;
            this.logger = logger;
        }

      //  [HttpPost]
        [HttpPost("Sendmail")]
        public IActionResult Contact(ContactViewModel contactViewModel) // string Name, string Email, string Subject, string Message)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var all = UserService.GetAllIncludedDatas(0, 0, 1, 0, contactViewModel.Name);

                    string Eml;
                    string FName;
                    string SecStamp;
                    foreach (var item in all)
                    {
                        Eml = item.Email;
                        FName = item.FullName;
                        SecStamp = item.SecurityStamp;
                        contactViewModel.Email = SecStamp;


                        var emailHost = Configuration.GetValue<string>("Email:smtp:Host");
                        var emailPort = Configuration.GetValue<int>("Email:smtp:Port");
                        var emailUsername = Configuration.GetValue<string>("Email:smtp:Username");
                        var emailPassword = Configuration.GetValue<string>("Email:smtp:Password");
                        var emailFrom = Configuration.GetValue<string>("Email:smtp:FromEmail");

                        var Subject = Configuration.GetValue<string>("Email:smtp:Subject");
                        var Message = Configuration.GetValue<string>("Email:smtp:Message");
                        var Footer = Configuration.GetValue<string>("Email:smtp:Footer");
                        Message = "Dear " + FName + ",<br>" + Message + "UserName="+ contactViewModel.Name + "&Token=" + SecStamp+"</H5>" + Footer;

                        //instantiate a new MimeMessage
                        var message = new MimeMessage();
                        //Setting the To e-mail address
                       // message.To.Add(new MailboxAddress(contactViewModel.Name, contactViewModel.Email));
                        message.To.Add(new MailboxAddress(FName, Eml));

                        message.From.Add(new MailboxAddress("E-mail From Khalifa Univercity", emailFrom));

                        //E-mail subject 
                        if (string.IsNullOrEmpty(contactViewModel.Subject))
                        {
                            message.Subject = Subject;
                        }
                        else
                        {
                            message.Subject = contactViewModel.Subject;
                        }
                        //E-mail message body
                        if (string.IsNullOrEmpty(contactViewModel.Message))
                        {
                            message.Body = new TextPart(TextFormat.Html)
                            {

                                Text = Message //+ " Message was sent by: " + contactViewModel.Name + " E-mail: " + contactViewModel.Email
                            };
                        }
                        else
                        {
                            message.Body = new TextPart(TextFormat.Html)
                            {
                                Text = contactViewModel.Message//+ " Message was sent by: " + contactViewModel.Name + " E-mail: " + contactViewModel.Email
                            };
                        }



                        using (var emailClient = new SmtpClient())
                        {
                            emailClient.Connect(emailHost, emailPort, false);
                            emailClient.Authenticate(emailUsername, emailPassword);

                            emailClient.Send(message);
                            emailClient.Disconnect(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Oops! We have a problem here {ex.Message}";
                }
            }
            //return View();
            //  return Ok(contactViewModel.Email);
          
            //string[] s = all.Select(p => p.Items).ToArray();
            string[] stringArray = new string[] {  "{ 'token' :'" + contactViewModel.Email + "'}" };
            string jsonResponse = stringArray[0];
            //jsonResponse = jsonResponse.Replace("'", "\"");
            //var jsonString = JsonConvert.SerializeObject(jsonResponse);
            //dynamic parsedJson = JsonConvert.DeserializeObject(jsonString);
            //return Ok(parsedJson);

            var jsonString = JsonConvert.SerializeObject(contactViewModel);
            dynamic parsedJson = JsonConvert.DeserializeObject(jsonString);
            return Ok(parsedJson);
        }



    }

}