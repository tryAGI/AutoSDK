//HintName: G.Models.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format to use for the subtitle file, either 'srt' or 'webvtt'<br/>
    /// Default Value: srt
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType value)
        {
            return value switch
            {
                GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Srt => "srt",
                GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Webvtt => "webvtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? ToEnum(string value)
        {
            return value switch
            {
                "srt" => GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Srt,
                "webvtt" => GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Webvtt,
                _ => null,
            };
        }
    }
}