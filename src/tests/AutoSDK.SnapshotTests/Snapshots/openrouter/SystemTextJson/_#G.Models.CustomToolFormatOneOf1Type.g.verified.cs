//HintName: G.Models.CustomToolFormatOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomToolFormatOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolFormatOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatOneOf1Type value)
        {
            return value switch
            {
                CustomToolFormatOneOf1Type.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomToolFormatOneOf1Type.Grammar,
                _ => null,
            };
        }
    }
}