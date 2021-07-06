using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Resources
{
    public class DistinctTextResponseResource
    {
        public int DistinctWordCount { get; set; }
        public IEnumerable<string> WatchlistWords { get; set; }
    }
}
