using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.Layout
{
    public class _WriterLayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
