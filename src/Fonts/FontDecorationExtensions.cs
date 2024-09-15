using VleaStwo.MasaBlazorHelpers.CssHelpers;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Fonts
{
    public static class FontDecorationExtensions
    {
        public static string Prefix => prefix;
        private const string prefix = "text-decoration-";

        internal static string GetFontDecorationName(this FontDecorations fd) => HelpersExtensions.GetEnumName(fd);

        public static string Text(this FontDecorations fd) => prefix + fd.GetFontDecorationName();
    }

}
