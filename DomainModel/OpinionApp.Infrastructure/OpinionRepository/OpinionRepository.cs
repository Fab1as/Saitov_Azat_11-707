using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpinionApp.Core;
using OpinionApp.Infrastructure.ObjectiveRepository;

namespace OpinionApp.Infrastructure.OpinionRepository
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly OpinionAppContext _context;

        public OpinionRepository(OpinionAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Opinion>> GetOpinions()
        {
            return await _context.Opinions.ToListAsync();
        }

        public async Task<Opinion> GetOpinionByObjective(Objective objective)
        {
            return await _context.Opinions.SingleOrDefaultAsync(x => x.Objective == objective);
        }

        public void AddOpinion(Opinion opinion)
        {
            _context.Add(opinion);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}