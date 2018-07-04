using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpinionApp.Core;

namespace OpinionApp.Infrastructure.ObjectiveRepository
{
    public class ObjectiveRepository : IObjectiveRepository
    {
        private readonly ObjectiveAppContext _context;

        public ObjectiveRepository(ObjectiveAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Objective>> GetObjectives()
        {
            return await _context.Objectives.ToListAsync();
        }


        public void AddObjective(Objective objective)
        {
            _context.Add(objective);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
