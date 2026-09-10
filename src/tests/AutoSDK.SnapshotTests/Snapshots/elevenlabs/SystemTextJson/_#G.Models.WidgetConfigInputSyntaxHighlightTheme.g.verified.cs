//HintName: G.Models.WidgetConfigInputSyntaxHighlightTheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigInputSyntaxHighlightTheme
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
    public static class WidgetConfigInputSyntaxHighlightThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigInputSyntaxHighlightTheme value)
        {
            return value switch
            {
                WidgetConfigInputSyntaxHighlightTheme.Dark => "dark",
                WidgetConfigInputSyntaxHighlightTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigInputSyntaxHighlightTheme? ToEnum(string value)
        {
            return value switch
            {
                "dark" => WidgetConfigInputSyntaxHighlightTheme.Dark,
                "light" => WidgetConfigInputSyntaxHighlightTheme.Light,
                _ => null,
            };
        }
    }
}