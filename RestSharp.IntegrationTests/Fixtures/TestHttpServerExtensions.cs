using System.Collections.Generic;
using System.Net;

namespace RestSharp.IntegrationTests.Fixtures
{
    public static class TestHttpServerExtensions
    {
        static readonly Dictionary<HttpListenerRequest, string> RequestContent = new Dictionary<HttpListenerRequest, string>();

        internal static void ClearContent(this HttpListenerRequest request)
        {
            if (RequestContent.ContainsKey(request))
                RequestContent.Remove(request);
        }

        public static HttpListenerResponse ContentType(this HttpListenerResponse response, string contentType)
        {
            response.ContentType = contentType;
            return response;
        }

        public static HttpListenerResponse StatusCode(this HttpListenerResponse response, int statusCode)
        {
            response.StatusCode = statusCode;
            return response;
        }
    }
}