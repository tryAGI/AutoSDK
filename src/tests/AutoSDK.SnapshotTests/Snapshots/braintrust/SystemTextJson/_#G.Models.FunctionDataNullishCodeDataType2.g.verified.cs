//HintName: G.Models.FunctionDataNullishCodeDataType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataNullishCodeDataType2
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishCodeDataType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishCodeDataType2 value)
        {
            return value switch
            {
                FunctionDataNullishCodeDataType2.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishCodeDataType2? ToEnum(string value)
        {
            return value switch
            {
                "inline" => FunctionDataNullishCodeDataType2.Inline,
                _ => null,
            };
        }
    }
}