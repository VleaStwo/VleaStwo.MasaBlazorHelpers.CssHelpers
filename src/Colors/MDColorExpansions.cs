using System.Runtime.CompilerServices;

using mdc = VleaStwo.MasaBlazorHelpers.CssHelpers.Colors.MaterialDesignColors;


namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Colors
{
    public static partial class MDColorExpansions
    {
        public const string Black = "black";
        public const string BlackText = Black + Connector + Text;
        public const string White = "white";
        public const string WhiteText = White + Connector + Text;

        const string Text = "text";
        const string Connector = "--";

        static string GetColorName(this mdc color) => HelpersExtensions.GetEnumName(color);

        #region Background
        #region Dark
        public static string DarkAndText(this mdc color, int level) => color.Dark(level) + " " + WhiteText;

        public static string DarkAndText(this DarkLevel level, mdc color) => color.DarkAndText((int)level);

        public static string Dark(this mdc color) => color.Dark(0);

        public static string Dark(this mdc color, int level)
        {
            FixDark(ref level);

            return color.Darken(level);
        }
        static string Darken(this mdc color, int level) => color.GetBackgroundClass(level);
        public static string Dark(this DarkLevel level, mdc color) => color.Dark((int)level);
        #endregion

        #region Light
        public static string LightAndText(this mdc color, int level) => color.Light(level) + " " + BlackText;

        public static string LightAndText(this LightLevel level, mdc color) => color.LightAndText((int)level);

        public static string Light(this mdc color, int level)
        {
            FixLight(ref level);

            return color.Lighten(level);
        }
        static string Lighten(this mdc color, int level) => color.GetBackgroundClass(level);

        public static string Light(this LightLevel level, mdc color) => color.Light((int)level);
        #endregion

        #region Accent

        public static string Accent(this mdc color, int level)
        {
            if (color < 0)
            {
                throw new System.ArgumentException(color + "不支持AccentColor");
            }
            FixAccent(ref level);

            return color.GetBackgroundClass(level); // Accent无需修复
        }

        public static string Accent(this AccentLevel level, mdc color) => color.Accent((int)level);
        #endregion

        static string GetBackgroundClass(this mdc color, int level, [CallerMemberName] string type = "") =>
            level is 0 ? color.GetBackgroundName() : $"{color.GetBackgroundName()}{type.ToLower()}-{level}";

        internal static string GetBackgroundName(this mdc color) => color.GetColorName() + " ";
        #endregion


        #region Foreground

        #region DarkText
        public static string DarkTextAndBackground(this mdc color, int level) => color.DarkText(level) + " " + White;

        public static string DarkTextAndBackground(this DarkLevel level, mdc color) =>
            color.DarkTextAndBackground((int)level);

        public static string DarkText(this mdc color, int level)
        {
            FixDark(ref level);
            return color.DarkenText(level);
        }
        static string DarkenText(this mdc color, int level) => color.GetForegroundClass(level);
        public static string DarkText(this DarkLevel level, mdc color) => color.DarkText((int)level);
        #endregion

        #region LightText
        public static string LightTextAndBackground(this mdc color, int level) => color.LightText(level) + " " + Black;

        public static string LightTextAndBackground(this LightLevel level, mdc color) => color.LightText((int)level);

        public static string LightText(this mdc color, int level)
        {
            FixLight(ref level);

            return color.LightenText(level);
        }
        static string LightenText(this mdc color, int level) => color.GetForegroundClass(level);
        public static string LightText(this LightLevel level, mdc color) => color.LightText((int)level);
        #endregion

        #region AccentText
        public static string AccentText(this mdc color, int level)
        {
            if (color < 0)
            {
                throw new System.ArgumentException(color + "不支持AccentColor");
            }
            FixAccent(ref level);

            return color.GetForegroundClass(level); // Accent无需修复
        }
        public static string AccentText(this AccentLevel level, mdc color) => color.AccentText((int)level);

        #endregion




        static string GetForegroundClass(this mdc color, int level, [CallerMemberName] string type = "") =>
            level is 0
                ? color.GetForegroundName()
                : $"{color.GetForegroundName()}{Text + Connector}{type.ToLower()[..(type.Length - 4)]}-{level}";

        internal static string GetForegroundName(this mdc color) => color.GetColorName() + Connector + Text + " ";
        #endregion


        #region Level Range

        const int Dark_Min = 0;
        const int Dark_Max = 4;
        const int Accent_Min = 1;
        const int Accent_Max = 4;
        const int Light_Min = 1;
        const int Light_Max = 5;

        static bool FixDark(ref int level) => FixRange(ref level, Dark_Min, Dark_Max);

        static bool FixAccent(ref int level) => FixRange(ref level, Accent_Min, Accent_Max);

        static bool FixLight(ref int level) => FixRange(ref level, Light_Min, Light_Max);

        static bool FixRange(ref int level, int min, int max)
        {
            if (level < min)
            {
                level = min;
                return true;
            }
            else if (level > max)
            {
                level = max;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
