using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangFireController : ControllerBase
    {
    
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("testing");
        }
        
    }
}
