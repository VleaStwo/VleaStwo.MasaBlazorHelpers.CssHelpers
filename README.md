# VleaStwo.MasaBlazor.Helpers
## VleaStwo.MasaBlazor.Helpers.CssHelpers
### Colors

通过枚举约束颜色,提供智能提示
[MaterialDesignColors](/src/Colors/MaterialDesignColors.cs)
[LightLevel](/src/Colors/LightLevel.cs)
[DarkLevel](/src/Colors/DarkLevel.cs)
[AccentLevel](/src/Colors/AccentLevel.cs)
[使用](/src/Colors/MDColorExpansions.cs)
示例:
```csharp
public class Program
{
    static void Main(string[] args)
    {
        var color = MaterialDesignColors.Red;

        Test(color);
    }

    public static void Test(MaterialDesignColors color)
    {
        // color == red

        Print("MDC.Red.Dark(0)", color.Dark(0));
        Print("MDC.Red.Dark(1)", color.Dark(1));
        Print("MDC.Red.DarkAndText(1)", color.DarkAndText(1));

        Print("MDC.Red.Light(1)", color.Light(1));
        Print("MDC.Red.Light(10)", color.Light(10));
        Print("MDC.Red.LightAndText(1)", color.LightAndText(1));

        Print("MDC.Red.Accent(1)", color.Accent(1));
        Print("MDC.Red.Accent(5)", color.Accent(5));

        Print("MDC.Red.DarkText(0)", color.DarkText(0));
        Print("MDC.Red.DarkText(1)", color.DarkText(1));
        Print("MDC.Red.DarkText(1)", color.DarkTextAndBackground(1));

        Print("MDC.Red.LightText(1)", color.LightText(1));
        Print("MDC.Red.LightText(10)", color.LightText(10));
        Print("MDC.Red.DarkText(1)", color.LightTextAndBackground(1));

        Print("MDC.Red.AccentText(1)", color.AccentText(1));
        Print("MDC.Red.AccentText(5)", color.AccentText(5));
    }

    static void Print(string text, string display)
    {
        Console.WriteLine("code: " + text + ": ");
        Console.Write("\t\t");
        Console.WriteLine("get => " + display);
        Console.WriteLine();
    }
}
```

### Styles
通过枚举约束风格,提供智能提示
[MaterialDesignStyles](/src/Styles/MaterialDesignStyles.cs)