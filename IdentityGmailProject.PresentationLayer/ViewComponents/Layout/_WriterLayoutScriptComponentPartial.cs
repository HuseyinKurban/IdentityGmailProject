using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.Layout
{
    public class _WriterLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
