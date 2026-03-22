//HintName: G.Models.WidgetConfigOutputSyntaxHighlightTheme2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigOutputSyntaxHighlightTheme2
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
    public static class WidgetConfigOutputSyntaxHighlightTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigOutputSyntaxHighlightTheme2 value)
        {
            return value switch
            {
                WidgetConfigOutputSyntaxHighlightTheme2.Dark => "dark",
                WidgetConfigOutputSyntaxHighlightTheme2.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigOutputSyntaxHighlightTheme2? ToEnum(string value)
        {
            return value switch
            {
                "dark" => WidgetConfigOutputSyntaxHighlightTheme2.Dark,
                "light" => WidgetConfigOutputSyntaxHighlightTheme2.Light,
                _ => null,
            };
        }
    }
}