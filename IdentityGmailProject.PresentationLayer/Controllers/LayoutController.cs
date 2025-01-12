using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
