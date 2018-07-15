using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerseAutoFramework.Helpers
{
    public static class RestAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseurl = "https://jsonplaceholder.typicode.com";


        public static RestClient setUrl(string endpoint)
        {
            var url = baseurl + endpoint;
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static IRestResponse getResponse()
        {
            return client.Execute(restRequest);
        }

    }
}
