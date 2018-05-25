using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sansagol.CyberFox.CyberFoxApi.Models;

namespace Sansagol.CyberFox.CyberFoxApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly CyberFox_DevContext _Context = null;
        public ValuesController(CyberFox_DevContext context)
        {
            _Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _Context.SnUser.Select(u => u.Name).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var item = _Context.SnUser.FirstOrDefault(f => f.SnUserId.ToLower().Equals(id.ToLower()));
            if (item == null)
            {
                return NotFound();
            }
            return Json(item);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
