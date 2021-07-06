using DeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Repositories
{
    public class WatchWordRepository : Repository<WatchWord>, IWatchWordRepository
    {
        public WatchWordRepository(TextDbContext context) : base(context)
        {
        }
    }
}
