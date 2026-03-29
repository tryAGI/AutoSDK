//HintName: G.Models.VideoToTextControllerVideoTranscriptionRequestOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum VideoToTextControllerVideoTranscriptionRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Txt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToTextControllerVideoTranscriptionRequestOutputFormat value)
        {
            return value switch
            {
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Json => "json",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Plain => "plain",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Srt => "srt",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Txt => "txt",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToTextControllerVideoTranscriptionRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Json,
                "plain" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Plain,
                "srt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Srt,
                "txt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Txt,
                "vtt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Vtt,
                _ => null,
            };
        }
    }
}