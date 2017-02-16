using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4Demo.Controllers
{
    [Authorize]
    public class DemoController : Controller
    {

        [HttpGet]
        public IActionResult DemoTest()
        {
            return new JsonResult(true);
        }
    }
}
