using DeveloperTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest
{
    public interface IUnitOfWork : IDisposable
    {
        IWatchWordRepository WatchWords { get; }
        IDistinctTextRepository DistinctTexts { get; }
        Task<int> CommitAsync();
    }
}
