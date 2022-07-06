using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) return NotFound();
            return Ok(thing);
        }

        [HttpGet]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Users.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;

        }

        [HttpGet]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }



    }
}