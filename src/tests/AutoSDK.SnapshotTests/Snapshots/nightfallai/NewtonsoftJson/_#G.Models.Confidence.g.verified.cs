//HintName: G.Models.Confidence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Confidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LIKELY")]
        Likely,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSSIBLE")]
        Possible,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNLIKELY")]
        Unlikely,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERY_LIKELY")]
        VeryLikely,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERY_UNLIKELY")]
        VeryUnlikely,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Confidence value)
        {
            return value switch
            {
                Confidence.Likely => "LIKELY",
                Confidence.Possible => "POSSIBLE",
                Confidence.Unlikely => "UNLIKELY",
                Confidence.VeryLikely => "VERY_LIKELY",
                Confidence.VeryUnlikely => "VERY_UNLIKELY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Confidence? ToEnum(string value)
        {
            return value switch
            {
                "LIKELY" => Confidence.Likely,
                "POSSIBLE" => Confidence.Possible,
                "UNLIKELY" => Confidence.Unlikely,
                "VERY_LIKELY" => Confidence.VeryLikely,
                "VERY_UNLIKELY" => Confidence.VeryUnlikely,
                _ => null,
            };
        }
    }
}