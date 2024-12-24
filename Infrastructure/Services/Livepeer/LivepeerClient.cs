using System.Net.Http;
using System.Net.Http.Headers;

namespace LivepeerTest.Infrastructure.Services.Livepeer
{
    public class LivepeerClient
    {
        private readonly HttpClient _client;
        private readonly string _apiKey;

        public LivepeerClient(HttpClient client)
        {
            _apiKey = "48ca896f-048b-4697-bd5b-78554d9a38f1";
            _client = client;

            _client.BaseAddress = new Uri("https://livepeer.studio");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public HttpClient Client => _client;
    }
}
