namespace Sportsbot
{
    public class APIRequestor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public async Task<API_Models.GameRoot?> GetGameDataAsync(string uri)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsAsync<API_Models.GameRoot>();

                return responseContent;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public async Task<API_Models.TeamRoot?> GetTeamDataAsync(string uri)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsAsync<API_Models.TeamRoot>();

                return responseContent;
            }

            return null;
        }
    }
}
