using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using Microsoft.ML;
using SentimentWebApi.Models.RestModel;

namespace SentimentWebApi.Controllers
{
    [ApiController]
    [Route("api/v1/sentiment")]

    public class SentimentController : ControllerBase
    {
        private readonly ILogger<SentimentController> _logger;
        public SentimentController(ILogger<SentimentController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost]
        [Route("predict")]
        public RestSentiment PostSentiment(InputSentiment inputData)
        {
            MLSentimentModel.ModelInput processData = new MLSentimentModel.ModelInput()
            {
                Review = inputData.Summany 
            };

            // Make a single prediction on the sample data and print results
            var result = MLSentimentModel.Predict(processData);
            var resultSentiment = new RestSentiment
            {
                Prediction = result.Prediction,
                Score = new ScoreStruct
                {
                    None = result.Score[0],
                    Positive = result.Score[1],
                    Negative = result.Score[2],
                    Sentiment = result.Score[3]
                }
            };

            return resultSentiment;
        }
        [HttpPost]
        [Route("icon")]
        public RestIcon GetIcon(InputSentiment inputData)
        {
            MLSentimentModel.ModelInput processData = new MLSentimentModel.ModelInput()
            {
                Review = inputData.Summany
            };
            var result = MLSentimentModel.Predict(processData);
            var resultIcon = new RestIcon
            {
                Icon = "💤"
            };
            return resultIcon;
        }

    }
}
