using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Domain
{
    public class Example
    {
        public Example()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateTime = DateTime.Now;
        }

        #region 属性
        public string Id { get; set; }
        public int No { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }

        #endregion

        #region 关系
        public virtual ICollection<Tag> Tags { get; set; }

        #endregion

        #region 方法

        #endregion
    }
}
