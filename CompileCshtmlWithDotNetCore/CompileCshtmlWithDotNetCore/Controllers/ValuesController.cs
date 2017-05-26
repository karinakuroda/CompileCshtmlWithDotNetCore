using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CompileCshtmlWithDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly ViewRender view;
        public ValuesController(ViewRender view)
        {

            this.view = view;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };

              var teste = new Teste();
            teste.Code = 123;
            var html = this.view.Render("Index",teste);
            return new string[] { "value1", html };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
