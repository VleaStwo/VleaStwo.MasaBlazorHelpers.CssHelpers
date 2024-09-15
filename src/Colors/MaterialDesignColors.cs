using System;
using System.ComponentModel;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Colors
{
    /// <summary>
    /// 只有正数支持accent
    /// </summary>
    public enum MaterialDesignColors
    {
        /// <summary>
        /// 该颜色不支持Accent
        /// </summary>
        [Description("该颜色不支持Accent")]
        Brown = -3,

        /// <summary>
        /// 该颜色不支持Accent
        /// </summary>
        [Description("该颜色不支持Accent")]
        Blue_Grey = -2,

        /// <summary>
        /// 该颜色不支持Accent
        /// </summary>
        [Description("该颜色不支持Accent")]
        Grey = -1,

        /// <summary>
        /// 请直接填写 'black' 或 'white'
        /// </summary>
        [Obsolete("请直接填写 'black' 或 'white'", true)]
        Shades = 0,
        Red,
        Pink,
        Purple,
        Deep_Purple,
        Indigo,
        Blue,
        Light_Blue,
        Cyan,
        Teal,
        Green,
        Light_Green,
        Lime,
        Yellow,
        Amber,
        Orange,
        Deep_Orange,
    }
}
