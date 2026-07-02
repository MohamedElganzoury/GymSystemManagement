using GymManagementSystem.DAL.Repoistory.Implementation;
using GymManagementSystem.DAL.Repoistory.Interfaces;
using GymSystemManagement.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystemManagement.Controllers
{
    public class PlanController : Controller
    {
        //private readonly GymDbContext dbContext;
        private readonly IPlanRepoistory _planrepoistory;
        public PlanController(IPlanRepoistory planRepoistory)
        {
            _planrepoistory = planRepoistory;
        }
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var plans = await _planrepoistory.GetAllAsync(ct: ct);
            return View(plans);
        }
        public async Task<IActionResult> Details(int id, CancellationToken ct)
        {
            var plan = await _planrepoistory.GetbyIdAsync(id, ct);

            if (plan is null)
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
