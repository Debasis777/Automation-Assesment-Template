using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutomationTests.Api;

namespace AutomationTests.Api.Factory
{
    public static class ApiClientFactory
    {
        public static IReqResApi CreateReqResApiClient()
        {
            var settings = new RefitSettings
            {
                AuthorizationHeaderValueGetter = (request, cancellationToken) => Task.FromResult("reqres-free-v1")
            };

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://reqres.in")
            };

            httpClient.DefaultRequestHeaders.Add("x-api-key", "reqres-free-v1");

            return RestService.For<IReqResApi>(httpClient, settings);
        }
    }
}
