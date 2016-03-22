using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Example.Service;
using Example.Data;

namespace Example.Api.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private ExampleService _exampleService;

        public ValuesController():this(new ExampleService(new ExampleContext("ExampleContext")))
        {

        }
        public ValuesController(ExampleService exampleService)
        {
            this._exampleService = exampleService;
        }

        // POST api/AddExample
        [HttpPost]
        public IHttpActionResult AddExample(Core.Domain.Example example)
        {
            if (ModelState.IsValid)
            {
                _exampleService.AddExample(example);
                return Ok();
            }
            else
            {
                return InternalServerError();
            }
            
        }

        // PUT api/
        [HttpPut]
        public IHttpActionResult EditExample(Core.Domain.Example example)
        {
            if (ModelState.IsValid)
            {
                _exampleService.EditExample(example);
                return Ok();
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE api/
        [HttpDelete]
        public IHttpActionResult DeleteExampleById(string Id)
        {
            try
            {
                _exampleService.DeleteExampleById(Id);
                return Ok();
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }
        public Core.Domain.Example GetExampleById(string Id)
        {
            return _exampleService.GetExampleById(Id);
        }

        public IEnumerable<Core.Domain.Example> GetAllExample()
        {
            return _exampleService.GetAllExample();
        }
        public PageResult<Core.Domain.Example> GetExampleByPageResult(int pageNumber, int pageSize)
        {
            return _exampleService.GetExampleByPageResult(pageNumber,pageSize);
        }
    }
}
