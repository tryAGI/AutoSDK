//HintName: G.Models.WidgetConfigInputSyntaxHighlightTheme2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WidgetConfigInputSyntaxHighlightTheme2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="light")]
        Light,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dark")]
        Dark,
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
                WidgetConfigInputSyntaxHighlightTheme2.Light => "light",
                WidgetConfigInputSyntaxHighlightTheme2.Dark => "dark",
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
                "light" => WidgetConfigInputSyntaxHighlightTheme2.Light,
                "dark" => WidgetConfigInputSyntaxHighlightTheme2.Dark,
                _ => null,
            };
        }
    }
}