//HintName: G.Models.CustomToolFormatOneOf1Syntax.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomToolFormatOneOf1Syntax
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lark")]
        Lark,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolFormatOneOf1SyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatOneOf1Syntax value)
        {
            return value switch
            {
                CustomToolFormatOneOf1Syntax.Lark => "lark",
                CustomToolFormatOneOf1Syntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatOneOf1Syntax? ToEnum(string value)
        {
            return value switch
            {
                "lark" => CustomToolFormatOneOf1Syntax.Lark,
                "regex" => CustomToolFormatOneOf1Syntax.Regex,
                _ => null,
            };
        }
    }
}