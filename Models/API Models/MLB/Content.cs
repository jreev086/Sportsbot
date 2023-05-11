using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Content
    {
        public Content()
        {
            Link = string.Empty;
        }

        [JsonPropertyName("link")]
        public string Link { get;set; }
    }

}
