using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Api.Controllers
{
    [ApiController]
    [Route("api/contact")]
    
    public class ContactController : ControllerBase
    {
        private static readonly string[] Names = { "Sam", "Emaly", "Cameron", "Rachel" };
        private static readonly string[] Emails = { "sammcmasters97@gmail.com", "ehowell800@gmail.com", "cforsh10@gmail.com", "rforshey@gmail.com" };

        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetContact()
        {
            var rnd = new Random();
            var contact = new Contact
            {
                Name = Names[rnd.Next(Names.Length)],
                Email = Emails[rnd.Next(Emails.Length)],
            };

            return Ok(contact);

        }
    }
}
