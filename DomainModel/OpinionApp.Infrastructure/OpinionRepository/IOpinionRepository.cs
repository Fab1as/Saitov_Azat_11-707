using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpinionApp.Core;

namespace OpinionApp.Infrastructure.OpinionRepository
{
    public interface IOpinionRepository
    {
        Task<IEnumerable<Opinion>> GetOpinions();

        Task<Opinion> GetOpinionByObjective(Objective objective);

        void AddOpinion(Opinion opinion);

        Task<int> Save();
    }
}
