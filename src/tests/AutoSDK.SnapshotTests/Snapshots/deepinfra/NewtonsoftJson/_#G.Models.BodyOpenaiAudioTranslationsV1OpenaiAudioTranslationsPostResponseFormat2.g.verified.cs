//HintName: G.Models.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2
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
    public static class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2 value)
        {
            return value switch
            {
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Json => "json",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Text => "text",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Srt => "srt",
                BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Json,
                "verbose_json" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.VerboseJson,
                "text" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Text,
                "srt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Srt,
                "vtt" => BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.Vtt,
                _ => null,
            };
        }
    }
}