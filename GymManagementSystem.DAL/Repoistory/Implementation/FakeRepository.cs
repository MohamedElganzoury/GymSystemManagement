using GymManagementSystem.DAL.Repoistory.Interfaces;
using GymSystemManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Repoistory.Implementation
{
    public class FakeRepository : IPlanRepoistory
    {
        public Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeelteAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Plan>> GetAllAsync(bool Tracking = false, CancellationToken ct = default)
        {
            var List = new List<Plan>()
            {
                new Plan()
                {
                    Name="Test"
                }
            };
            return List;
        }

        public Task<Plan?> GetbyIdAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
