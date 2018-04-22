using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TopHundred.API.Controllers
{
    [Route("/api/icoitems")]
    public class IcoListsController : Controller
    {
        [HttpGet]
        public IActionResult GetIcos()
        {
            return null;
        }
    }
}
