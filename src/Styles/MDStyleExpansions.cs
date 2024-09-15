using VleaStwo.MasaBlazorHelpers.CssHelpers;

using mds = VleaStwo.MasaBlazorHelpers.CssHelpers.Styles.MaterialDesignStyles;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Styles
{
    public static class MDStyleExpansions
    {
        internal static string GetStyleName(this mds style) => HelpersExtensions.GetEnumName(style);

        public static string Style(this mds style, bool? dark = null) =>
            style.GetStyleName()
            + dark switch
            {
                null => null,
                true => " " + Colors.MDColorExpansions.WhiteText,
                false => " " + Colors.MDColorExpansions.BlackText,
            };

        public static string Dark(this mds style) => style.Style(true);

        public static string Light(this mds style) => style.Style(false);

        public static string Text(this mds style) => style.GetStyleName() + "--text";
    }
}
