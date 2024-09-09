//HintName: G.Models.RedactedAudioStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the redacted audio
    /// </summary>
    public enum RedactedAudioStatus
    {
        /// <summary>
        /// 
        /// </summary>
        RedactedAudioReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RedactedAudioStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RedactedAudioStatus value)
        {
            return value switch
            {
                RedactedAudioStatus.RedactedAudioReady => "redacted_audio_ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RedactedAudioStatus? ToEnum(string value)
        {
            return value switch
            {
                "redacted_audio_ready" => RedactedAudioStatus.RedactedAudioReady,
                _ => null,
            };
        }
    }
}