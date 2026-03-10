//HintName: G.Models.GetDubbingTranscriptsFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format to return transcript in. For subtitles use either 'srt' or 'webvtt', and for a full transcript use 'json'. The 'json' format is not yet supported for Dubbing Studio.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDubbingTranscriptsFormatType
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingTranscriptsFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingTranscriptsFormatType value)
        {
            return value switch
            {
                GetDubbingTranscriptsFormatType.Srt => "srt",
                GetDubbingTranscriptsFormatType.Webvtt => "webvtt",
                GetDubbingTranscriptsFormatType.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingTranscriptsFormatType? ToEnum(string value)
        {
            return value switch
            {
                "srt" => GetDubbingTranscriptsFormatType.Srt,
                "webvtt" => GetDubbingTranscriptsFormatType.Webvtt,
                "json" => GetDubbingTranscriptsFormatType.Json,
                _ => null,
            };
        }
    }
}