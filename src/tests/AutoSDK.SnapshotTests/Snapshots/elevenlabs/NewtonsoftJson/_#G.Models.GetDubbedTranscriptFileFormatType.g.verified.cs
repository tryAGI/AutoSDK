//HintName: G.Models.GetDubbedTranscriptFileFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format to return transcript in. For subtitles use either 'srt' or 'webvtt', and for a full transcript use 'json'. The 'json' format is not yet supported for Dubbing Studio.<br/>
    /// Default Value: srt
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDubbedTranscriptFileFormatType
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
    public static class GetDubbedTranscriptFileFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbedTranscriptFileFormatType value)
        {
            return value switch
            {
                GetDubbedTranscriptFileFormatType.Json => "json",
                GetDubbedTranscriptFileFormatType.Srt => "srt",
                GetDubbedTranscriptFileFormatType.Webvtt => "webvtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbedTranscriptFileFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDubbedTranscriptFileFormatType.Json,
                "srt" => GetDubbedTranscriptFileFormatType.Srt,
                "webvtt" => GetDubbedTranscriptFileFormatType.Webvtt,
                _ => null,
            };
        }
    }
}