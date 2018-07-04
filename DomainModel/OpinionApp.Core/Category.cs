using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionApp.Core
{
    class Category : ValueObject<Category>
    {
        public string CategoryName;

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
