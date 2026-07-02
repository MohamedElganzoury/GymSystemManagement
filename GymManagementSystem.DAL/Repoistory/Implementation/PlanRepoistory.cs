using GymManagementSystem.DAL.Repoistory.Interfaces;
using GymSystemManagement.DbContexts;
using GymSystemManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Repoistory.Implementation
{
    public class PlanRepoistory : IPlanRepoistory
    {
        private readonly GymDbContext _dbContext;
        public PlanRepoistory(GymDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            _dbContext.Plans.Add(plan);
           return await _dbContext.SaveChangesAsync(ct);
        }
         
        public async Task<int> DeelteAsync(Plan plan, CancellationToken ct = default)
        {
            _dbContext.Plans.Remove(plan);
            return await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<Plan>> GetAllAsync(bool Tracking=false,CancellationToken ct = default)
        {
            IQueryable<Plan> query = Tracking ? _dbContext.Plans : _dbContext.Plans.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<Plan?> GetbyIdAsync(int id, CancellationToken ct = default)
        {
           return await _dbContext.Plans.FindAsync(id,ct);
        }

        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            _dbContext.Plans.Update(plan);
            return await _dbContext.SaveChangesAsync(ct);
        }
    }
}
