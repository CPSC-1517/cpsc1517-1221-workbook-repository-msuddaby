using Microsoft.EntityFrameworkCore;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class BuildVersionService
    {
        private readonly WestWindContext _context;

        public BuildVersionService(WestWindContext context)
        {
            _context = context;
        }

        public BuildVersion GetLatestVersion()
        {
            return _context.BuildVersions.FirstOrDefault();
        }
    }
}
