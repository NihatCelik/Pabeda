using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Pabeda.Projem.WebAPI
{
    public static class WebApiSettings
    {
        public static HttpClient webApiClient = new HttpClient();

        static WebApiSettings()
        {
            webApiClient.BaseAddress = new Uri("http://localhost:59702/api/");
            webApiClient.DefaultRequestHeaders.Clear();
            webApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}