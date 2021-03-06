using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Enums
{
    enum HttpResponseStatusCode
    {
        Ok = 200,
        Created = 201,
        Found = 302,
        SeeOther = 303,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 403,
        InternalServerError = 500
    }
}