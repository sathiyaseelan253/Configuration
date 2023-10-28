using ConfigurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConfigurationSettings _configurationSettings;
        public HomeController(IOptions<ConfigurationSettings> configurationSettings)
        {
            _configurationSettings= configurationSettings.Value;
        }
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.ClientID = _configurationSettings.ClientID;
            ViewBag.ClientSecret = _configurationSettings.ClientSecret;
            return View();
        }
    }
}
