using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetListAllCategory();
            return View(values);
        }
    }
}
