using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPLanningService.Domain;

namespace WorkPlanningService.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ShiftSchedule> ShiftSchedules { get; set; }
    }
}
