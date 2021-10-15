using miniHttp.HTTP.Enums;
using miniHttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Responses
{
    interface IHttpResponse
    {
        HttpResponseStatusCode StatusCode { get; }
        IHttpHeaderCollection Headers { get; }
        byte[] Content { get; }
        void AddHeader(HttpHeader header);
        byte[] GetBytes();
    }
}
