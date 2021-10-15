using miniHttp.HTTP.Enums;
using miniHttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Responses
{
    class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {

        }

        public HttpResponse(HttpResponseStatusCode statusCode)
        {

        }

        public HttpResponseStatusCode StatusCode { get; private set; }

        public IHttpHeaderCollection Headers { get; private set; }

        public byte[] Content { get; private set; }

        public void AddHeader(HttpHeader header)
        {
            throw new NotImplementedException();
        }

        public byte[] GetBytes()
        {
            throw new NotImplementedException();
        }
    }
}
