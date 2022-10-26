using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;
using WestWindSystem.Entities;

namespace WestWindWebApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly CategoryServices _categoryServices;

        public List<Category> Categories { get; private set; } = new List<Category>();

        public IndexModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public void OnGet()
        {
            Categories = _categoryServices.List();
        }
    }
}
