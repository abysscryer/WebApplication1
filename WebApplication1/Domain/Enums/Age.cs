using System.ComponentModel;

namespace WebApplication1.Domain.Enums
{
    public enum Age
    {
        /// <summary>
        /// Default
        /// </summary>
        [Description("All")]
        All,
        [Description("Adult")]
        Adult,
        [Description("College")]
        College,
        [Description("U13-U18")]
        U13_U18,
        [Description("U12")]
        U12
    }
}
