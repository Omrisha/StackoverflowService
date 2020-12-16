using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StackOverflowApp.Boundries;
using StackOverflowApp.Services;

namespace StackOverflowApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StackoverflowController : ControllerBase
    {
        private readonly IStackoverflowService _service;

        private readonly ILogger<StackoverflowController> _logger;

        public StackoverflowController(ILogger<StackoverflowController> logger, IStackoverflowService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("GetBestQuestions")]
        public Task<IEnumerable<Question>> GetBestQuestions()
        {
            return this._service.GetBestQuestions();
        }
        
        [HttpGet("GetBestAnswers/{questionId}")]
        public Task<IEnumerable<Answer>> GetBestAnswers(int questionId)
        {
            return this._service.GetBestAnswers(questionId);
        }
        
        [HttpGet("GetOwner/{answerId}")]
        public Task<OwnerEntity> GetOwner(int answerId)
        {
            return this._service.GetOwner(answerId);
        }
    }
}