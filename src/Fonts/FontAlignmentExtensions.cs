using VleaStwo.MasaBlazorHelpers.CssHelpers;
using VleaStwo.MasaBlazorHelpers.CssHelpers.Breakpoints;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Fonts
{
    public static class FontAlignmentExtensions
    {
        public static string Prefix => prefix;
        private const string prefix = "text-decoration-";

        internal static string GetFontAlignmentName(this FontAlignments fa) => HelpersExtensions.GetEnumName(fa);

        public static string Text(this FontAlignments fd) => fd.GetFontAlignmentName();

        public static string Text(this FontAlignments fs, MBreakpoints bp) =>
            prefix + MBreakpointExtensions.Join(bp) + fs.GetFontAlignmentName();
    }
}
