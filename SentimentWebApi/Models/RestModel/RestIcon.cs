using Newtonsoft.Json;

namespace SentimentWebApi.Models.RestModel
{
    public class RestIcon
    {
        [JsonProperty("icon")]
        public string Icon { get; set; } = "💤";
    }
}
