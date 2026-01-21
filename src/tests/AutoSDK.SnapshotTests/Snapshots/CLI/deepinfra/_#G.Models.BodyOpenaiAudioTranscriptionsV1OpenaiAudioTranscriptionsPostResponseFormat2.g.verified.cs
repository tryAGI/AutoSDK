//HintName: G.Models.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2 value)
        {
            return value switch
            {
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Json => "json",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Text => "text",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Srt => "srt",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Json,
                "verbose_json" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.VerboseJson,
                "text" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Text,
                "srt" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Srt,
                "vtt" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2.Vtt,
                _ => null,
            };
        }
    }
}