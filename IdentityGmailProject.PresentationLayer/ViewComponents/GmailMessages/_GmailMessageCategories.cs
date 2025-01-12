using IdentityGmailProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.GmailMessages
{
    public class _GmailMessageCategories:ViewComponent
    {
        private  readonly ICategoryService _categoryService;

        public _GmailMessageCategories(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
