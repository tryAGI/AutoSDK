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
        HarmProbabilityUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HIGH")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEDIUM")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEGLIGIBLE")]
        Negligible,
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
                SafetyRatingProbability.HarmProbabilityUnspecified => "HARM_PROBABILITY_UNSPECIFIED",
                SafetyRatingProbability.High => "HIGH",
                SafetyRatingProbability.Low => "LOW",
                SafetyRatingProbability.Medium => "MEDIUM",
                SafetyRatingProbability.Negligible => "NEGLIGIBLE",
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
                "HARM_PROBABILITY_UNSPECIFIED" => SafetyRatingProbability.HarmProbabilityUnspecified,
                "HIGH" => SafetyRatingProbability.High,
                "LOW" => SafetyRatingProbability.Low,
                "MEDIUM" => SafetyRatingProbability.Medium,
                "NEGLIGIBLE" => SafetyRatingProbability.Negligible,
                _ => null,
            };
        }
    }
}