//HintName: G.Models.WidgetConfigResponseModelSyntaxHighlightTheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigResponseModelSyntaxHighlightTheme
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
    public static class WidgetConfigResponseModelSyntaxHighlightThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigResponseModelSyntaxHighlightTheme value)
        {
            return value switch
            {
                WidgetConfigResponseModelSyntaxHighlightTheme.Dark => "dark",
                WidgetConfigResponseModelSyntaxHighlightTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigResponseModelSyntaxHighlightTheme? ToEnum(string value)
        {
            return value switch
            {
                "dark" => WidgetConfigResponseModelSyntaxHighlightTheme.Dark,
                "light" => WidgetConfigResponseModelSyntaxHighlightTheme.Light,
                _ => null,
            };
        }
    }
}