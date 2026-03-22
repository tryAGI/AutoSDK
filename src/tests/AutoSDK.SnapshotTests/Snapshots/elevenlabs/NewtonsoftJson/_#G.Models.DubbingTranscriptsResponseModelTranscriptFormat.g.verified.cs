//HintName: G.Models.DubbingTranscriptsResponseModelTranscriptFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DubbingTranscriptsResponseModelTranscriptFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="srt")]
        Srt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webvtt")]
        Webvtt,
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
                DubbingTranscriptsResponseModelTranscriptFormat.Json => "json",
                DubbingTranscriptsResponseModelTranscriptFormat.Srt => "srt",
                DubbingTranscriptsResponseModelTranscriptFormat.Webvtt => "webvtt",
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
                "json" => DubbingTranscriptsResponseModelTranscriptFormat.Json,
                "srt" => DubbingTranscriptsResponseModelTranscriptFormat.Srt,
                "webvtt" => DubbingTranscriptsResponseModelTranscriptFormat.Webvtt,
                _ => null,
            };
        }
    }
}