//HintName: G.Models.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat value)
        {
            return value switch
            {
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Json => "json",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Srt => "srt",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Text => "text",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Json,
                "srt" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Srt,
                "text" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Text,
                "verbose_json" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.VerboseJson,
                "vtt" => BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}