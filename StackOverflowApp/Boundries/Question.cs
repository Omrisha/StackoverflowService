using System;
using Newtonsoft.Json;

namespace StackOverflowApp.Boundries
{
    [Serializable]
    public class Question
    {
        [JsonProperty(PropertyName = "tags")]
        public string[] Tags { get; set; }
        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }
        [JsonProperty(PropertyName = "is_answered")]
        public bool IsAnswerd { get; set; }
        [JsonProperty(PropertyName = "view_count")]
        public int ViewCount { get; set; }
        [JsonProperty(PropertyName = "protected_date")]
        public int BountyAmount { get; set; }
        [JsonProperty(PropertyName = "accepted_answer_id")]
        public int BountyClosesDate { get; set; }
        [JsonProperty(PropertyName = "answer_count")]
        public int AnswerCount { get; set; }
        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }
        [JsonProperty(PropertyName = "last_activity_date")]
        public int LastActivityDate { get; set; }
        [JsonProperty(PropertyName = "creation_date")]
        public int CreationDate { get; set; }
        [JsonProperty(PropertyName = "last_edit_date")]
        public int LastEditDate { get; set; }
        [JsonProperty(PropertyName = "question_id")]
        public int QuestionId { get; set; }
        [JsonProperty(PropertyName = "content_license")]
        public string ContentLicense { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}