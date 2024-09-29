//HintName: G.Models.SafetyRatingProbability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The probability of harm for this content.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SafetyRatingProbability
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_PROBABILITY_UNSPECIFIED")]
        HARMPROBABILITYUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEGLIGIBLE")]
        NEGLIGIBLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW")]
        LOW,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEDIUM")]
        MEDIUM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HIGH")]
        HIGH,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetyRatingProbabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyRatingProbability value)
        {
            return value switch
            {
                SafetyRatingProbability.HARMPROBABILITYUNSPECIFIED => "HARM_PROBABILITY_UNSPECIFIED",
                SafetyRatingProbability.NEGLIGIBLE => "NEGLIGIBLE",
                SafetyRatingProbability.LOW => "LOW",
                SafetyRatingProbability.MEDIUM => "MEDIUM",
                SafetyRatingProbability.HIGH => "HIGH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyRatingProbability? ToEnum(string value)
        {
            return value switch
            {
                "HARM_PROBABILITY_UNSPECIFIED" => SafetyRatingProbability.HARMPROBABILITYUNSPECIFIED,
                "NEGLIGIBLE" => SafetyRatingProbability.NEGLIGIBLE,
                "LOW" => SafetyRatingProbability.LOW,
                "MEDIUM" => SafetyRatingProbability.MEDIUM,
                "HIGH" => SafetyRatingProbability.HIGH,
                _ => null,
            };
        }
    }
}