//HintName: G.Models.OpenAIVoicemailDetectionPlanType.g.cs

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
    public enum OpenAIVoicemailDetectionPlanType
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
    public static class OpenAIVoicemailDetectionPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoicemailDetectionPlanType value)
        {
            return value switch
            {
                OpenAIVoicemailDetectionPlanType.Audio => "audio",
                OpenAIVoicemailDetectionPlanType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoicemailDetectionPlanType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => OpenAIVoicemailDetectionPlanType.Audio,
                "transcript" => OpenAIVoicemailDetectionPlanType.Transcript,
                _ => null,
            };
        }
    }
}