using APIUtils;
using NUnit.Framework;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ApiLayer.StepDefinitions
{
    [Binding]
    public class APITestStepDefinitions
    {
        private readonly APIUtility _apiUtility;
        private RestResponse _response;

        public APITestStepDefinitions()
        {
            _apiUtility = new APIUtility("https://petstore.swagger.io/v2");
        }

        [Given(@"the API endpoint is set to /pet")]
        public void GivenTheAPIEndpointIsSetToPet()
        {
            // This is handled in the APIUtility constructor
        }

        [When(@"a GET request is sent")]
        public async Task WhenAGETRequestIsSent()
        {
            _response = await _apiUtility.GetAsync("/pet");
        }

        [When(@"a POST request is sent")]
        public async Task WhenAPOSTRequestIsSent()
        {
            var pet = new { id = 12345, name = "Doggie", status = "available" };
            _response = await _apiUtility.PostAsync("/pet", pet);
        }

        [When(@"a PUT request is sent")]
        public async Task WhenAPUTRequestIsSent()
        {
            var updatedPet = new { id = 12345, name = "Doggie", status = "sold" };
            _response = await _apiUtility.PutAsync("/pet", updatedPet);
        }

        [When(@"a DELETE request is sent")]
        public async Task WhenADELETERequestIsSent()
        {
            _response = await _apiUtility.DeleteAsync("/pet/12345");
        }

        [Then(@"the response status code should be 200")]
        public void ThenTheResponseStatusCodeShouldBe200()
        {
            Assert.AreEqual(200, (int)_response.StatusCode);
        }
    }
}