//HintName: G.Models.CreateTranscriptionRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the transcript output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.
    /// <br/>Default Value: json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranscriptionRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
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
        [global::System.Runtime.Serialization.EnumMember(Value="verbose_json")]
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vtt")]
        Vtt,
    }

    public static class CreateTranscriptionRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateTranscriptionRequestResponseFormat value)
        {
            return value switch
            {
                CreateTranscriptionRequestResponseFormat.Json => "json",
                CreateTranscriptionRequestResponseFormat.Text => "text",
                CreateTranscriptionRequestResponseFormat.Srt => "srt",
                CreateTranscriptionRequestResponseFormat.VerboseJson => "verbose_json",
                CreateTranscriptionRequestResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranscriptionRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateTranscriptionRequestResponseFormat.Json,
                "text" => CreateTranscriptionRequestResponseFormat.Text,
                "srt" => CreateTranscriptionRequestResponseFormat.Srt,
                "verbose_json" => CreateTranscriptionRequestResponseFormat.VerboseJson,
                "vtt" => CreateTranscriptionRequestResponseFormat.Vtt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranscriptionRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateTranscriptionRequestResponseFormat.Json,
                1 => CreateTranscriptionRequestResponseFormat.Text,
                2 => CreateTranscriptionRequestResponseFormat.Srt,
                3 => CreateTranscriptionRequestResponseFormat.VerboseJson,
                4 => CreateTranscriptionRequestResponseFormat.Vtt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}