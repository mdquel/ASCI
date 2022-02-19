using Newtonsoft.Json;

namespace SentimentWebApi.Models.RestModel
{
    public class RestSentiment
    {
        [JsonProperty("predition")]
        public string Prediction { get; set; } = "";
        [JsonProperty("score")]
        public ScoreStruct Score { get; set; }   
    }
    public class ScoreStruct
    {
        [JsonProperty("negative")]
        public float Negative { get; set; } = 0;
        [JsonProperty("none")]
        public float None { get; set; } = 0;
        [JsonProperty("positive")]
        public float Positive { get; set; } = 0;
        [JsonProperty("sentiment")]
        public float Sentiment { get; set; } = 0;
    }
}
