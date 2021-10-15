using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using miniHttp.HTTP.Common;

namespace miniHttp.HTTP.Headers
{
    class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullorEmpty(key, nameof(key));
            CoreValidator.ThrowIfNullorEmpty(value, nameof(value));
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }
    }

}
