//HintName: G.Models.WidgetConfigInputSyntaxHighlightTheme2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigInputSyntaxHighlightTheme2
    {
        /// <summary>
        /// 
        /// </summary>
        Dark,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetConfigInputSyntaxHighlightTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigInputSyntaxHighlightTheme2 value)
        {
            return value switch
            {
                WidgetConfigInputSyntaxHighlightTheme2.Dark => "dark",
                WidgetConfigInputSyntaxHighlightTheme2.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigInputSyntaxHighlightTheme2? ToEnum(string value)
        {
            return value switch
            {
                "dark" => WidgetConfigInputSyntaxHighlightTheme2.Dark,
                "light" => WidgetConfigInputSyntaxHighlightTheme2.Light,
                _ => null,
            };
        }
    }
}