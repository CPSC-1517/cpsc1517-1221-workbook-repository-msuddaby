using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;
using WestWindSystem.Entities;

namespace WestWindWebApp.Pages
{
    public class QueryModel : PageModel
    {
        private readonly CategoryServices _categoryServices;

        public QueryModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public List<Category> CategoryList { get; set; }

        [BindProperty]
        public Category CategorySelection { get; set; }

        public void OnGet()
        {
            CategoryList = _categoryServices.List();
        }
    }
}
