using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    public static class Utility
    {
        private static string _BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        public static T InteractToAPI<T>(string apiUri, bool Post = false, object formBody = null)
        {
             
        var client = new RestClient(_BaseUrl + apiUri);
        RestRequest request = null;
            if (Post == false)
                request = new RestRequest(Method.GET);
            else
                request = new RestRequest(Method.POST);

        request.AddHeader("Content-Type", "application/json");
            request.Timeout = 5 * 60 * 1000;
            if (formBody != null)
            {
                var json = JsonConvert.SerializeObject(formBody);
        request.AddParameter("application/json", json, ParameterType.RequestBody);
            }

    IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}