using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using StackOverflowApp.Boundries;

namespace StackOverflowApp.Services
{
    public interface IStackoverflowService
    {
        Task<IEnumerable<Question>> GetBestQuestions();
        Task<IEnumerable<Answer>> GetBestAnswers(int qeustionId);
        Task<OwnerEntity> GetOwner(int answerId);
    }
}