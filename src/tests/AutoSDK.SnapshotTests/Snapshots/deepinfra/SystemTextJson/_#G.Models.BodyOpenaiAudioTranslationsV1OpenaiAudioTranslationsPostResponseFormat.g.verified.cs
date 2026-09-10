//HintName: G.Models.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat
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
    public static class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat value)
        {
            return value switch
            {
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Json => "json",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Srt => "srt",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Text => "text",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Json,
                "srt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Srt,
                "text" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Text,
                "verbose_json" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.VerboseJson,
                "vtt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}