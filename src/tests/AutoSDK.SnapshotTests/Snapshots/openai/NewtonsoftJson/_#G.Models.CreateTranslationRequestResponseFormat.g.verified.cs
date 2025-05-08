//HintName: G.Models.CreateTranslationRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.<br/>
    /// Default Value: json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranslationRequestResponseFormat
    {
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="srt")]
        Srt,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbose_json")]
        VerboseJson,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vtt")]
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranslationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationRequestResponseFormat value)
        {
            return value switch
            {
                CreateTranslationRequestResponseFormat.Json => "json",
                CreateTranslationRequestResponseFormat.Text => "text",
                CreateTranslationRequestResponseFormat.Srt => "srt",
                CreateTranslationRequestResponseFormat.VerboseJson => "verbose_json",
                CreateTranslationRequestResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateTranslationRequestResponseFormat.Json,
                "text" => CreateTranslationRequestResponseFormat.Text,
                "srt" => CreateTranslationRequestResponseFormat.Srt,
                "verbose_json" => CreateTranslationRequestResponseFormat.VerboseJson,
                "vtt" => CreateTranslationRequestResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}