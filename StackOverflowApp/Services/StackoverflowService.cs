using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StackOverflowApp.Boundries;

namespace StackOverflowApp.Services
{
    public class StackoverflowService : IStackoverflowService
    {
        private readonly HttpClient _client;

        public StackoverflowService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Question>> GetBestQuestions()
        {
            try
            {
                var response = await _client.GetAsync("questions?page=1&pagesize=5&order=desc&sort=votes&site=stackoverflow");

                if (response.IsSuccessStatusCode)
                {
                    var serializedString = await response.Content.ReadAsStringAsync();
                    var items =  JsonConvert.DeserializeObject<Dictionary<string, object>>(serializedString);
                    var questions = new List<string>();

                     return JsonConvert.DeserializeObject<IEnumerable<Question>>(items["items"].ToString());
                }
                else
                {
                    return Array.Empty<Question>();
                }
                
            }
            catch (Exception e)
            {
                return Array.Empty<Question>();
            }
        }

        public async Task<IEnumerable<Answer>> GetBestAnswers(int qeustionId)
        {
            try
            {
                var response = await _client.GetAsync($"questions/{qeustionId}/answers?page=1&pagesize=5&order=desc&sort=votes&site=stackoverflow");

                if (response.IsSuccessStatusCode)
                {
                    var serializedString = await response.Content.ReadAsStringAsync();
                    var items =  JsonConvert.DeserializeObject<Dictionary<string, object>>(serializedString);
                    var answers = new List<string>();

                    return JsonConvert.DeserializeObject<IEnumerable<Answer>>(items["items"].ToString());
                }
                else
                {
                    return Array.Empty<Answer>();
                }
                
            }
            catch (Exception e)
            {
                return Array.Empty<Answer>();
            }
        }

        public async Task<OwnerEntity> GetOwner(int answerId)
        {
            try
            {
                // Getting answer data
                var response = await _client.GetAsync($"answers/{answerId}?order=desc&sort=activity&site=stackoverflow");

                if (response.IsSuccessStatusCode)
                {
                    var serializedString = await response.Content.ReadAsStringAsync();
                    var items =  JsonConvert.DeserializeObject<Dictionary<string, object>>(serializedString);
                    var answers = JsonConvert.DeserializeObject<Answer[]>(items["items"].ToString());

                    if (answers.Length == 0)
                    {
                        throw new Exception("Owner not found");
                    }
                    var userId = answers[0].Owner.UserId;

                    // Getting user data for answer
                    var userResponse =
                        await _client.GetAsync($"users/{userId}?order=desc&sort=reputation&site=stackoverflow");

                    if (response.IsSuccessStatusCode)
                    {
                        var serializedUserString = await userResponse.Content.ReadAsStringAsync();
                        var itemsOfUser =  JsonConvert.DeserializeObject<Dictionary<string, object>>(serializedUserString);

                        var users = itemsOfUser["items"].ToString();
                        var user = JsonConvert.DeserializeObject<OwnerEntity[]>(users);

                        return user.Length > 0 ? user[0] : new OwnerEntity();
                    }
                    else
                    {
                        return new OwnerEntity();
                    }
                }
                else
                {
                    throw new Exception($"Returned status code: {response.StatusCode}");
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}