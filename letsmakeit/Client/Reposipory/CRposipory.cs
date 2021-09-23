using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace letsmakeit.Client.Reposipory
{
    public class CRposipory : IRposipory
    {
        private readonly IHttpService httpService;
        private string url = "api/doui";
        public Insert(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task Create(Class1 obj)
        {
            var response = await httpService.Post(url, obj);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
