using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Eduhome.Services
{
    public class LayoutService
    {
        private readonly EduhomeDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutService(EduhomeDbContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public Setting GetSetting()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            return setting;

        }


    }
}
