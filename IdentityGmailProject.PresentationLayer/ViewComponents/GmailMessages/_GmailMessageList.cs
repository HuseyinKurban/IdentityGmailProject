using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.GmailMessages
{

    public class _GmailMessageList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
           
                return View();
            
        }
    }
}