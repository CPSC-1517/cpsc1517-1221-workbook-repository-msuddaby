using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<BuildVersion> GetLatestVersion()
        {
            return await _context.BuildVersions.FirstOrDefaultAsync();
        }
    }
}
