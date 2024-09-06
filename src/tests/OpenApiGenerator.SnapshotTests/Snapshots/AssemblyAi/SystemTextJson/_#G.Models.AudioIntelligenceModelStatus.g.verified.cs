//HintName: G.Models.AudioIntelligenceModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either success, or unavailable in the rare case that the model failed
    /// </summary>
    public enum AudioIntelligenceModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioIntelligenceModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioIntelligenceModelStatus value)
        {
            return value switch
            {
                AudioIntelligenceModelStatus.Success => "success",
                AudioIntelligenceModelStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioIntelligenceModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => AudioIntelligenceModelStatus.Success,
                "unavailable" => AudioIntelligenceModelStatus.Unavailable,
                _ => null,
            };
        }
    }
}