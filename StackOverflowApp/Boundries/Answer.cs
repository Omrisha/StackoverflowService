using System;
using Newtonsoft.Json;

namespace StackOverflowApp.Boundries
{
    [Serializable]
    public class Answer
    {
        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }
        [JsonProperty(PropertyName = "is_accepted")]
        public bool IsAccepted { get; set; }
        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }
        [JsonProperty(PropertyName = "last_activity_date")]
        public int LastActivityDate { get; set; }
        [JsonProperty(PropertyName = "last_edit_date")]
        public int LastEditDate { get; set; }
        [JsonProperty(PropertyName = "creation_date")]
        public int CreationDate { get; set; }
        [JsonProperty(PropertyName = "answer_id")]
        public int AnswerId { get; set; }
        [JsonProperty(PropertyName = "question_id")]
        public int QuestionId { get; set; }
        [JsonProperty(PropertyName = "content_license")]
        public string ContentLicense { get; set; }
    }
}