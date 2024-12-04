//HintName: G.Models.AudioResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.<br/>
    /// Default Value: json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioResponseFormat
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
    public static class AudioResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseFormat value)
        {
            return value switch
            {
                AudioResponseFormat.Json => "json",
                AudioResponseFormat.Text => "text",
                AudioResponseFormat.Srt => "srt",
                AudioResponseFormat.VerboseJson => "verbose_json",
                AudioResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioResponseFormat.Json,
                "text" => AudioResponseFormat.Text,
                "srt" => AudioResponseFormat.Srt,
                "verbose_json" => AudioResponseFormat.VerboseJson,
                "vtt" => AudioResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}