using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [Route("chat")]
    [ApiController]
    public class MessageRouter : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "say some greeting";
        }

        [HttpGet("{message}")]
        public string Get(string message)
        {
            message = message.ToLower();
            if (message.Equals("hii"))
                return "Hello";
            if (message.Equals("hello"))
                return "Hii";
            return "Invalid";
        }
    }
}