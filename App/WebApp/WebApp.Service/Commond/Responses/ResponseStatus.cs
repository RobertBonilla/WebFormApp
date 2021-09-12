using System;
using System.Net;

namespace WebApp.Service.Commond.Responses
{
    [Serializable]
    public class ResponseStatus
    {
        public HttpStatusCode HttpCode { get; set; }
        public string Message { get; set; }
    }
}