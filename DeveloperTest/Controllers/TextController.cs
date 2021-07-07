using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DeveloperTest.Models;
using DeveloperTest.Resources;
using DeveloperTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;
        private readonly IMapper _mapper;

        public TextController(ITextService textService, IMapper mapper)
        {
            _textService = textService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<DistinctTextResponseResource>> GetDistinctWordCountAndWatchlistWords(DistinctTextRequestResource request)
        {
            try
            {
                var textToCreate = _mapper.Map<DistinctTextRequestResource, DistinctText>(request);

                textToCreate.DistinctWordCount = _textService.GetNumberOfDistinctWords(request.Text);
                textToCreate.Text = string.Join(" ", _textService.GetDistinctWords(request.Text));
                var createdText = await _textService.CreateDistinctText(textToCreate);

                //use the text we save to the DB as input to method to avoid looping through duplicate words
                var watchlistWords = await _textService.GetWatchlistWordsForText(textToCreate.Text);

                return Ok(new DistinctTextResponseResource { DistinctWordCount = textToCreate.DistinctWordCount, WatchlistWords = watchlistWords});
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            
        }
    }
}
