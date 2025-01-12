using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.Layout
{
    public class _WriterLayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
