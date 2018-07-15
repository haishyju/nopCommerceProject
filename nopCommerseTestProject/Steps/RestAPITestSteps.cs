using System;
using TechTalk.SpecFlow;
using nopCommerseAutoFramework.Helpers;


namespace nopCommerseTestProject.Steps
{
    [Binding]
    public class RestAPITestSteps
    {
        [Given(@"the endpoint is (.*)")]
        public void GivenTheEndpointIs(string endpoint)
        {
            RestAPIHelper.setUrl(endpoint);
        }

        
        [When(@"I send the RestRequest using GET")]
        public void WhenISendTheRestRequestUsingGET()
        {
            RestAPIHelper.CreateRequest();
        }
        
        [Then(@"I get the API Response in Json format")]
        public void ThenIGetTheAPIResponseInJsonFormat()
        { 
            var response = RestAPIHelper.getResponse();
            if(response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                Console.Write("TC passed");
            }

            else
            {
                Console.WriteLine("TC Failed");
            }
        }

    }
}
