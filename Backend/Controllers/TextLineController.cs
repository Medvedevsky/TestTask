using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Backend.Services;
namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextLineController : ControllerBase
    {
        readonly private TextLineService _service;
        public TextLineController(TextLineService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Thread.Sleep(5000);
            return _service.Data();
        }
    }
}
