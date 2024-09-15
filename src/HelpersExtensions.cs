using System;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers
{
    internal static class HelpersExtensions
    {
        internal static string GetEnumName(Enum @enum) => @enum.ToString().ToLower().Replace('_', '-');
    }
}
