using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackOverflowApp.Boundries
{
    [Serializable]
    public class OwnerEntity
    {
        [JsonProperty(PropertyName = "badge_counts")]
        public Dictionary<string, object> BadgesCount { get; set; }
        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; set; }
        [JsonProperty(PropertyName = "is_employee")]
        public bool IsEmployee { get; set; }
        [JsonProperty(PropertyName = "last_modified_date")]
        public int LastModifiedDate { get; set; }
        [JsonProperty(PropertyName = "last_access_date")]
        public int LastAccessDate { get; set; }
        [JsonProperty(PropertyName = "reputation_change_year")]
        public int ReputationChangeYear { get; set; }
        [JsonProperty(PropertyName = "reputation_change_quarter")]
        public int ReputationChangeQuarter { get; set; }
        [JsonProperty(PropertyName = "reputation_change_month")]
        public int ReputationChangeMonth { get; set; }
        [JsonProperty(PropertyName = "reputation_change_week")]
        public int ReputationChangeWeek { get; set; }
        [JsonProperty(PropertyName = "reputation_change_day")]
        public int ReputationChangeDay { get; set; }
        [JsonProperty(PropertyName = "reputation")]
        public int Reputation { get; set; }
        [JsonProperty(PropertyName = "creation_date")]
        public int CreationDate { get; set; }
        [JsonProperty(PropertyName = "user_type")]
        public string UserType { get; set; }
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
        [JsonProperty(PropertyName = "website_url")]
        public string WebsiteUrl { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }
        [JsonProperty(PropertyName = "profile_image")]
        public string PorfileImage { get; set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
    }
}