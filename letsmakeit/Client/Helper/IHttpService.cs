using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace letsmakeit.Client.Helper
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
    }
}
