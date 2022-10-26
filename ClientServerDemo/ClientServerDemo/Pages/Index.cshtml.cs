using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;
using WestWindSystem.Entities;

namespace ClientServerDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BuildVersionService _buildVersionService;
        private readonly CategoryServices _categoryServices;

        public BuildVersion CurrentBuildVersion { get; set; } = null!;
        public List<Category> CategoryList { get; set; } = new List<Category>();

        public IndexModel(ILogger<IndexModel> logger, BuildVersionService buildVersionService, CategoryServices categoryServices)
        {
            _logger = logger;
            _buildVersionService = buildVersionService;
            _categoryServices = categoryServices;
        }

        public void OnGet()
        {
            CurrentBuildVersion = _buildVersionService.GetLatestVersion();
            CategoryList = _categoryServices.List();
        }

    }
}