using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Data;

namespace Example.Service
{
    public class ExampleService
    {
        private ExampleContext _dbContext { get; set; }

        public ExampleService(ExampleContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void AddExample(Core.Domain.Example example)
        {

        }

        public void DeleteExampleById(string Id)
        {

        }
        public void EditExample(Core.Domain.Example example)
        {

        }

        public Core.Domain.Example GetExampleById(string Id)
        {
            return _dbContext.Example.FirstOrDefault(t=>t.Id==Id); 
        }
        public IEnumerable<Core.Domain.Example> GetAllExample()
        {
            return _dbContext.Example.AsQueryable().OrderByDescending(a => a.CreateTime);
        }

        public PageResult<Core.Domain.Example> GetExampleByPageResult(int pageNumber, int pageSize)
        {
            var result = new PageResult<Core.Domain.Example>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalResultCount = _dbContext.Example.Count(),
                ResultList = _dbContext.Example.AsQueryable().OrderByDescending(a => a.CreateTime)
                                                    .Skip(pageSize * (pageNumber < 1 ? 0 : pageNumber - 1))
                                                    .Take(pageSize)
            };
            return result;
        }
    }
}
