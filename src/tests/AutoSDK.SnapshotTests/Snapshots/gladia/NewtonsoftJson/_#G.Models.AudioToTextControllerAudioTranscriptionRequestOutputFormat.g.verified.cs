//HintName: G.Models.AudioToTextControllerAudioTranscriptionRequestOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioToTextControllerAudioTranscriptionRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plain")]
        Plain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="srt")]
        Srt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="txt")]
        Txt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vtt")]
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioToTextControllerAudioTranscriptionRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToTextControllerAudioTranscriptionRequestOutputFormat value)
        {
            return value switch
            {
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Json => "json",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Plain => "plain",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Srt => "srt",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Txt => "txt",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToTextControllerAudioTranscriptionRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Json,
                "plain" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Plain,
                "srt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Srt,
                "txt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Txt,
                "vtt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Vtt,
                _ => null,
            };
        }
    }
}