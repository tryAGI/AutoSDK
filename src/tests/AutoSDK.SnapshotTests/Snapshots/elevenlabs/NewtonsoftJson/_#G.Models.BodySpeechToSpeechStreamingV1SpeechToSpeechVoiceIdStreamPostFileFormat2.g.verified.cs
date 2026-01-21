//HintName: G.Models.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le_16")]
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2 value)
        {
            return value switch
            {
                BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2.PcmS16le16 => "pcm_s16le_16",
                BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2.PcmS16le16,
                "other" => BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2.Other,
                _ => null,
            };
        }
    }
}