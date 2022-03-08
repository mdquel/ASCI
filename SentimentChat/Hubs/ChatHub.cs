using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace SentimentChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            string sentimiento = "";
            var intentos = 0;
        Goto:
            var http = new HttpClient();
            var api = "https://localhost:5000/api/v1/sentiment/predict";
            var myContent = JsonConvert.SerializeObject(new
            {
                summany = message
            });

            var strContent = new StringContent(myContent, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(api),
                Method = HttpMethod.Post,
                Content = strContent
            };
            var response = http.SendAsync(request).Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var result = response.Content.ReadAsStringAsync().Result;
            }
            var body = response.Content.ReadAsStringAsync().Result;
            var resultData = JsonConvert.DeserializeObject<RespuestaAPI>(body);
            sentimiento = resultData.prediction == "positive" ? "😀 " : "😡 ";
            user = sentimiento + user;
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}