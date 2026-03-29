//HintName: G.Models.GoogleVoicemailDetectionPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the detection type to use for voicemail detection.<br/>
    /// - 'audio': Uses native audio models (default)<br/>
    /// - 'transcript': Uses ASR/transcript-based detection<br/>
    /// @default 'audio' (audio detection)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleVoicemailDetectionPlanType
    {
        /// <summary>
        /// Uses native audio models (default)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// Uses ASR/transcript-based detection
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleVoicemailDetectionPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleVoicemailDetectionPlanType value)
        {
            return value switch
            {
                GoogleVoicemailDetectionPlanType.Audio => "audio",
                GoogleVoicemailDetectionPlanType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleVoicemailDetectionPlanType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GoogleVoicemailDetectionPlanType.Audio,
                "transcript" => GoogleVoicemailDetectionPlanType.Transcript,
                _ => null,
            };
        }
    }
}