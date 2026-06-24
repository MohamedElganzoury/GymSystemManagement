using GymSystemManagement.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystemManagement.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext dbContext;
        public PlanController()
        {
            dbContext=new GymDbContext();
        }
        public async Task<IActionResult> Index()
        {
            var plans =await dbContext.Plans.ToListAsync();
            return View(plans);
        }
        public async Task<IActionResult> Details(int id)
        {
            var plan = await dbContext.Plans.FindAsync(id);
            if(plan is null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(plan);
            }
        }
    }
}
