using System;
using Newtonsoft.Json;

namespace StackOverflowApp.Boundries
{
    [Serializable]
    public class Owner
    {
        [JsonProperty(PropertyName = "reputation")]
        public int Reputation { get; set; }
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }
        [JsonProperty(PropertyName = "user_type")]
        public string UserType { get; set; }
        [JsonProperty(PropertyName = "accept_rate")]
        public int AcceptRate { get; set; }
        [JsonProperty(PropertyName = "profile_image")]
        public string ProfileImage { get; set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }
    }
}