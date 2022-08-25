using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlanningService.Infrastructure.Context;
using WorkPLanningService.Domain;

namespace WorkPlanningService.Infrastructure.Seeder
{
    public class Seeder
    {

        public async static Task Seed(ApplicationDbContext dbContext)
        {
            await dbContext.Database.EnsureCreatedAsync();

            await SeedUser(dbContext);
        }



        private static async Task SeedUser(ApplicationDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var users = SeederHelper<User>.GetData("user.json");
                await dbContext.Users.AddRangeAsync(users);
                await dbContext.SaveChangesAsync();
            }

        }
    }
}