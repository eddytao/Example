using System.Collections.Generic;

namespace Example.Data
{
    public class PageResult<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalResultCount { get; set; }
        public IEnumerable<T> ResultList { get; set; }
    }
}
