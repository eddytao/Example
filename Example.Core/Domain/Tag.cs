using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Domain
{
    public class Tag
    {

        #region 属性
        public string ExampleId { get; set; }
        public string Name { get; set; }

        #endregion

        #region 关系
        public virtual Example Example { get; set; }

        #endregion

        #region 方法

        #endregion
    }
}
