using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionApp.Core
{
    public class Objective : ValueObject<Objective>
    {
        public string Description { get; set; }

        public Objective(string description)
        {
            Description = description;
        }
    }
}
