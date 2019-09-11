using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Enums
{
    public enum Gender
    {
        /// <summary>
        /// Default
        /// </summary>
        [Description("All")]
        All,
        [Description("Co-ed")]
        Co_ed,
        [Description("Men")]
        Men,
        [Description("Women")]
        Women
    }
}
