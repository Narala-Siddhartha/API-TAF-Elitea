using RestSharp;
using System.Threading.Tasks;

namespace APIUtils
{
    public class APIUtility
    {
        private readonly RestClient _client;

        public APIUtility(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<RestResponse> GetAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> PostAsync(string endpoint, object body)
        {
            var request = new RestRequest(endpoint, Method.Post);
            request.AddJsonBody(body);
            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> PutAsync(string endpoint, object body)
        {
            var request = new RestRequest(endpoint, Method.Put);
            request.AddJsonBody(body);
            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> DeleteAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            return await _client.ExecuteAsync(request);
        }
    }
}