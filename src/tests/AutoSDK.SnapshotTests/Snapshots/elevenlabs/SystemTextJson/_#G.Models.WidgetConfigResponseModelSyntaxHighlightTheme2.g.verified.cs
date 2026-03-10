//HintName: G.Models.WidgetConfigResponseModelSyntaxHighlightTheme2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigResponseModelSyntaxHighlightTheme2
    {
        /// <summary>
        /// 
        /// </summary>
        Light,
        /// <summary>
        /// 
        /// </summary>
        Dark,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetConfigResponseModelSyntaxHighlightTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigResponseModelSyntaxHighlightTheme2 value)
        {
            return value switch
            {
                WidgetConfigResponseModelSyntaxHighlightTheme2.Light => "light",
                WidgetConfigResponseModelSyntaxHighlightTheme2.Dark => "dark",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigResponseModelSyntaxHighlightTheme2? ToEnum(string value)
        {
            return value switch
            {
                "light" => WidgetConfigResponseModelSyntaxHighlightTheme2.Light,
                "dark" => WidgetConfigResponseModelSyntaxHighlightTheme2.Dark,
                _ => null,
            };
        }
    }
}