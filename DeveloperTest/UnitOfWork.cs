using DeveloperTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TextDbContext _context;
        private WatchWordRepository WatchWords { get; }
        private DistinctTextRepository DistinctTexts { get; }

        IWatchWordRepository IUnitOfWork.WatchWords => WatchWords;

        IDistinctTextRepository IUnitOfWork.DistinctTexts => DistinctTexts;

        public UnitOfWork(TextDbContext context)
        {
            _context = context;
            WatchWords = new WatchWordRepository(context);
            DistinctTexts = new DistinctTextRepository(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
