using GymSystemManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Repoistory.Interfaces
{
    public interface IPlanRepoistory
    {
        Task<IEnumerable<Plan>> GetAllAsync(bool Tracking=false,CancellationToken ct=default);
        Task<Plan?> GetbyIdAsync(int id, CancellationToken ct = default);
        Task<int> AddAsync(Plan plan, CancellationToken ct = default);
        Task<int> UpdateAsync(Plan plan, CancellationToken ct = default);
        Task<int> DeelteAsync(Plan plan,CancellationToken ct= default);

    }
}
