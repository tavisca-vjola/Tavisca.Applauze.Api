﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tavisca.Applauze.Api.Models;

namespace Tavisca.Applauze.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoutoutController : ControllerBase
    {
        // GET: api/Shoutout
        // GET: api/Shoutout
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return null;
        }

    }
}
