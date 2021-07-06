using DeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Services
{
    public interface ITextService
    {
        int GetNumberOfDistinctWords(string text);
        IEnumerable<string> GetDistinctWords(string text);
        Task<DistinctText> CreateDistinctText(DistinctText newDistinctText);
        Task<IEnumerable<string>> GetWatchlistWordsForText(string text);
    }
}
