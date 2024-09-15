namespace VleaStwo.MasaBlazorHelpers.CssHelpers.Breakpoints
{
    public static class MBreakpointExtensions
    {
        internal static string GetMBreakpointName(this MBreakpoints bp) => HelpersExtensions.GetEnumName(bp);

        internal static string Join(MBreakpoints bp) => bp.GetMBreakpointName() + '-';
    }
}
