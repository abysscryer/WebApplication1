using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Enums
{
    public enum Distance
    {
        [Description("5mi")]
        Five,
        [Description("10mi")]
        Ten,
        /// <summary>
        /// Default
        /// </summary>
        [Description("15mi")]
        Fifteen,
        [Description("20mi")]
        Twenty,
        [Description("25mi")]
        TwentyFive
    }
}
