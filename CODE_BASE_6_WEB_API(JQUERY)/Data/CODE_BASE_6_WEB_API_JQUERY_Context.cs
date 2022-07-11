using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CODE_BASE_6_WEB_API_JQUERY_.Models;

namespace CODE_BASE_6_WEB_API_JQUERY_.Data
{
    public class CODE_BASE_6_WEB_API_JQUERY_Context : DbContext
    {
        public CODE_BASE_6_WEB_API_JQUERY_Context (DbContextOptions<CODE_BASE_6_WEB_API_JQUERY_Context> options)
            : base(options)
        {
        }

        public DbSet<CODE_BASE_6_WEB_API_JQUERY_.Models.Employee> Employee { get; set; }
    }
}
