using VleaStwo.MasaBlazorHelpers.CssHelpers;

namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Fonts
{
    public static class FontWeightExtensions
    {
        public static string Prefix => prefix;
        private const string prefix = "font-weight-";

        internal static string GetFontWeightName(this FontWeights fw) => HelpersExtensions.GetEnumName(fw);

        public static string Text(this FontWeights fw) => prefix + fw.GetFontWeightName();

        public static string Simple(bool? fw) =>
            fw switch
            {
                null => string.Empty,
                true => FontWeights.Bold.Text(),
                false => FontWeights.Light.Text()
            };
    }
}
