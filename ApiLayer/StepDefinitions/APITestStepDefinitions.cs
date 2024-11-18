using TechTalk.SpecFlow;
using APIUtils;
using NUnit.Framework;
using System.Threading.Tasks;
using RestSharp;

namespace ApiLayer.StepDefinitions
{
    [Binding]
    public class APITestStepDefinitions
    {
        private string _baseUrl;
        private IRestResponse _response;
        private object _requestBody;

        [Given(@"the API base URL is "(.*)"")]
        public void GivenTheAPIBaseUrlIs(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        [Given(@"the request body is")]
        public void GivenTheRequestBodyIs(string requestBody)
        {
            _requestBody = Newtonsoft.Json.JsonConvert.DeserializeObject(requestBody);
        }

        [When(@"I send a GET request to "(.*)"")]
        public async Task WhenISendAGETRequestTo(string endpoint)
        {
            _response = await APIUtility.GetAsync(_baseUrl, endpoint);
        }

        [When(@"I send a POST request to "(.*)"")]
        public async Task WhenISendAPOSTRequestTo(string endpoint)
        {
            _response = await APIUtility.PostAsync(_baseUrl, endpoint, _requestBody);
        }

        [When(@"I send a PUT request to "(.*)"")]
        public async Task WhenISendAPUTRequestTo(string endpoint)
        {
            _response = await APIUtility.PutAsync(_baseUrl, endpoint, _requestBody);
        }

        [When(@"I send a DELETE request to "(.*)"")]
        public async Task WhenISendADELETERequestTo(string endpoint)
        {
            _response = await APIUtility.DeleteAsync(_baseUrl, endpoint);
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)_response.StatusCode);
        }
    }
}