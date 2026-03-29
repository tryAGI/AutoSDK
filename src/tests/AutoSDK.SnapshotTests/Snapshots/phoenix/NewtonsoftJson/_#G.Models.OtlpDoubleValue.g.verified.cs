//HintName: G.Models.OtlpDoubleValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OtlpDoubleValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-Infinity")]
        MinusInfinity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Infinity")]
        Infinity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NaN")]
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