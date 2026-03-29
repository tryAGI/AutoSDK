//HintName: G.Models.OtlpDoubleValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OtlpDoubleValue
    {
        /// <summary>
        /// 
        /// </summary>
        MinusInfinity,
        /// <summary>
        /// 
        /// </summary>
        Infinity,
        /// <summary>
        /// 
        /// </summary>
        NaN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OtlpDoubleValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OtlpDoubleValue value)
        {
            return value switch
            {
                OtlpDoubleValue.MinusInfinity => "-Infinity",
                OtlpDoubleValue.Infinity => "Infinity",
                OtlpDoubleValue.NaN => "NaN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OtlpDoubleValue? ToEnum(string value)
        {
            return value switch
            {
                "-Infinity" => OtlpDoubleValue.MinusInfinity,
                "Infinity" => OtlpDoubleValue.Infinity,
                "NaN" => OtlpDoubleValue.NaN,
                _ => null,
            };
        }
    }
}