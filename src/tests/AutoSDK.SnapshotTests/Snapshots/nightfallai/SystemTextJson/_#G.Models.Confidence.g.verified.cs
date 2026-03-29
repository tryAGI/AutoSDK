//HintName: G.Models.Confidence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Confidence
    {
        /// <summary>
        /// 
        /// </summary>
        Likely,
        /// <summary>
        /// 
        /// </summary>
        Possible,
        /// <summary>
        /// 
        /// </summary>
        Unlikely,
        /// <summary>
        /// 
        /// </summary>
        VeryLikely,
        /// <summary>
        /// 
        /// </summary>
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