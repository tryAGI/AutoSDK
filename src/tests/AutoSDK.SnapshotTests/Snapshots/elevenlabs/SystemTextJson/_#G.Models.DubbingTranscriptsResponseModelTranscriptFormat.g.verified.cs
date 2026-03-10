//HintName: G.Models.DubbingTranscriptsResponseModelTranscriptFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DubbingTranscriptsResponseModelTranscriptFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Webvtt,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingTranscriptsResponseModelTranscriptFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingTranscriptsResponseModelTranscriptFormat value)
        {
            return value switch
            {
                DubbingTranscriptsResponseModelTranscriptFormat.Srt => "srt",
                DubbingTranscriptsResponseModelTranscriptFormat.Webvtt => "webvtt",
                DubbingTranscriptsResponseModelTranscriptFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingTranscriptsResponseModelTranscriptFormat? ToEnum(string value)
        {
            return value switch
            {
                "srt" => DubbingTranscriptsResponseModelTranscriptFormat.Srt,
                "webvtt" => DubbingTranscriptsResponseModelTranscriptFormat.Webvtt,
                "json" => DubbingTranscriptsResponseModelTranscriptFormat.Json,
                _ => null,
            };
        }
    }
}