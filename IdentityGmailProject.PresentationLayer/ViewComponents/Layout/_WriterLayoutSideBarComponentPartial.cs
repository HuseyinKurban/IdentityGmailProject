using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.Layout
{
    public class _WriterLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
