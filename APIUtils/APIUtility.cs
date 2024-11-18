using RestSharp;
using System.Threading.Tasks;

namespace APIUtils
{
    public static class APIUtility
    {
        private static RestClient client = new RestClient();

        public static async Task<IRestResponse> GetAsync(string baseUrl, string endpoint)
        {
            var request = new RestRequest(baseUrl + endpoint, Method.GET);
            return await client.ExecuteAsync(request);
        }

        public static async Task<IRestResponse> PostAsync(string baseUrl, string endpoint, object body)
        {
            var request = new RestRequest(baseUrl + endpoint, Method.POST);
            request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }

        public static async Task<IRestResponse> PutAsync(string baseUrl, string endpoint, object body)
        {
            var request = new RestRequest(baseUrl + endpoint, Method.PUT);
            request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }

        public static async Task<IRestResponse> DeleteAsync(string baseUrl, string endpoint)
        {
            var request = new RestRequest(baseUrl + endpoint, Method.DELETE);
            return await client.ExecuteAsync(request);
        }
    }
}