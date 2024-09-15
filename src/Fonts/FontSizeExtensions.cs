using VleaStwo.MasaBlazorHelpers.CssHelpers;
using VleaStwo.MasaBlazorHelpers.CssHelpers.Breakpoints;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Fonts
{
    public static class FontSizeExtensions
    {
        public static string Prefix => prefix;
        private const string prefix = "text-";

        internal static string GetFontSizeName(this FontSizes fs) => HelpersExtensions.GetEnumName(fs);

        public static string Text(this FontSizes fs) => prefix + fs.GetFontSizeName();

        public static string Text(this FontSizes fs, MBreakpoints bp) =>
            prefix + MBreakpointExtensions.Join(bp) + fs.GetFontSizeName();
    }
}
