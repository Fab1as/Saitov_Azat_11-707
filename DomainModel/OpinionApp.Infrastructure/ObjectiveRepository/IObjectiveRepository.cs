using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpinionApp.Core;

namespace OpinionApp.Infrastructure.ObjectiveRepository
{
    public interface IObjectiveRepository
    {
        Task<IEnumerable<Objective>> GetObjectives();

        void AddObjective(Objective objective);

        Task<int> Save();
    }
}
