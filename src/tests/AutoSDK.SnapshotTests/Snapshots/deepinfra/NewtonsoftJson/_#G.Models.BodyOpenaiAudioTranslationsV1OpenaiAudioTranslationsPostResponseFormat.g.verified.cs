//HintName: G.Models.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbose_json")]
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="srt")]
        Srt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vtt")]
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
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Text => "text",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Srt => "srt",
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
                "verbose_json" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.VerboseJson,
                "text" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Text,
                "srt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Srt,
                "vtt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}