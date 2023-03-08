using System;
using System.Threading;
using PlgRequest.CoreApiClient;
using PlgRequest.Utility;

namespace PlgRequest.Factory
{
     internal static class ApiClientFactory
    {
        private static Uri apiUri;

        private static Lazy<ApiClient> restClient = new Lazy<ApiClient>(
          () => new ApiClient()  ,
          LazyThreadSafetyMode.ExecutionAndPublication
        );

        static ApiClientFactory(){
            apiUri = new Uri(ApplicationSettings.webApiUrl);
        }

        public static ApiClient Instance
        {
            get{
                return restClient.Value;
            }
            
        }
    }
}