﻿using System;
using System.Collections.Generic;
using System.Text;

namespace miniHttp.HTTP.Headers
{
    interface IHttpHeaderCollection
    {
        void AddHeader(HttpHeader header);
        bool ContainsHeader(string key);
        HttpHeader GetHeader(string key);

    }
}
