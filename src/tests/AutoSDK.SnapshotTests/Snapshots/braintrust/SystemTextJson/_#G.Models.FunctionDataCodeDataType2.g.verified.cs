//HintName: G.Models.FunctionDataCodeDataType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataCodeDataType2
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataCodeDataType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataCodeDataType2 value)
        {
            return value switch
            {
                FunctionDataCodeDataType2.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataCodeDataType2? ToEnum(string value)
        {
            return value switch
            {
                "inline" => FunctionDataCodeDataType2.Inline,
                _ => null,
            };
        }
    }
}