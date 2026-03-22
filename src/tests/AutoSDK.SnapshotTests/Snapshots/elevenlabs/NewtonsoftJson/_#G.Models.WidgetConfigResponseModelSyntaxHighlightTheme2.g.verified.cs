//HintName: G.Models.WidgetConfigResponseModelSyntaxHighlightTheme2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WidgetConfigResponseModelSyntaxHighlightTheme2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dark")]
        Dark,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="light")]
        Light,
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
                WidgetConfigResponseModelSyntaxHighlightTheme2.Dark => "dark",
                WidgetConfigResponseModelSyntaxHighlightTheme2.Light => "light",
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
                "dark" => WidgetConfigResponseModelSyntaxHighlightTheme2.Dark,
                "light" => WidgetConfigResponseModelSyntaxHighlightTheme2.Light,
                _ => null,
            };
        }
    }
}