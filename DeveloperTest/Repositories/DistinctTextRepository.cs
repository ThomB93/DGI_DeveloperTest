using DeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Repositories
{
    public class DistinctTextRepository : Repository<DistinctText>, IDistinctTextRepository
    {
        public DistinctTextRepository(TextDbContext context) : base(context)
        {

        }
    }
}
