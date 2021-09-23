using letsmakeit.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace letsmakeit.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class InsertController : ControllerBase
    {
        private readonly Applicationdbcontext context;
        public InsertController(Applicationdbcontext context)
        {
            this.context = context;

        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Class1 obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
            return obj.ID;
        }

    }
}
