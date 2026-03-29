//HintName: G.Models.MetadataSendFeedbackRequestFeature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: letta-code
    /// </summary>
    public enum MetadataSendFeedbackRequestFeature
    {
        /// <summary>
        /// 
        /// </summary>
        LettaCode,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendFeedbackRequestFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendFeedbackRequestFeature value)
        {
            return value switch
            {
                MetadataSendFeedbackRequestFeature.LettaCode => "letta-code",
                MetadataSendFeedbackRequestFeature.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendFeedbackRequestFeature? ToEnum(string value)
        {
            return value switch
            {
                "letta-code" => MetadataSendFeedbackRequestFeature.LettaCode,
                "sdk" => MetadataSendFeedbackRequestFeature.Sdk,
                _ => null,
            };
        }
    }
}