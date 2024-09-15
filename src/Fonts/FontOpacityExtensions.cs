using VleaStwo.MasaBlazorHelpers.CssHelpers;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Fonts
{
    public static class FontOpacityExtensions
    {
        public static string Prefix => prefix;
        private const string prefix = "text--";

        internal static string GetFontOpacityName(this FontOpacities fo) => HelpersExtensions.GetEnumName(fo);

        public static string Text(this FontOpacities fo) => prefix + fo.GetFontOpacityName();
    }
}
