//HintName: G.Models.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2 value)
        {
            return value switch
            {
                BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2.PcmS16le16 => "pcm_s16le_16",
                BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2.PcmS16le16,
                "other" => BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2.Other,
                _ => null,
            };
        }
    }
}