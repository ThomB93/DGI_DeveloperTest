using DeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeveloperTest.Services
{
    public class TextService : ITextService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TextService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<string> GetDistinctWords(string text)
        {
            //a set only contains unique unordered values
            HashSet<String> uniqueWords =
            new HashSet<String>(text.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            return uniqueWords;
        }

        public int GetNumberOfDistinctWords(string text)
        {
            //Replace non-alphanumerical characters with a space
            text = new Regex("[^a-zA-Z0-9]").Replace(text, " ");

            //doesn't count empty strings
            var words = text.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Distinct().Count();
        }

        public async Task<DistinctText> CreateDistinctText(DistinctText newDistinctText)
        {
            await _unitOfWork.DistinctTexts.AddAsync(newDistinctText);
            await _unitOfWork.CommitAsync();

            return newDistinctText;
        
        }
        public async Task<IEnumerable<string>> GetWatchlistWordsForText(string text)
        {
            //get all watch words at once to avoid making too many queries to the DB
            IEnumerable<WatchWord> allWatchWords = await _unitOfWork.WatchWords.GetAllAsync();

            return (from word in text.Split(' ')
                    where allWatchWords.Any(w => w.Word == word)
                    select word).ToList();
        }
    }
}
