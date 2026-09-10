//HintName: G.Models.WidgetConfigOutputSyntaxHighlightTheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigOutputSyntaxHighlightTheme
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
    public static class WidgetConfigOutputSyntaxHighlightThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigOutputSyntaxHighlightTheme value)
        {
            return value switch
            {
                WidgetConfigOutputSyntaxHighlightTheme.Dark => "dark",
                WidgetConfigOutputSyntaxHighlightTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigOutputSyntaxHighlightTheme? ToEnum(string value)
        {
            return value switch
            {
                "dark" => WidgetConfigOutputSyntaxHighlightTheme.Dark,
                "light" => WidgetConfigOutputSyntaxHighlightTheme.Light,
                _ => null,
            };
        }
    }
}