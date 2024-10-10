//HintName: G.Models.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format to use for the subtitle file, either 'srt' or 'webvtt'
    /// </summary>
    public enum GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Webvtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType value)
        {
            return value switch
            {
                GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Srt => "srt",
                GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Webvtt => "webvtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? ToEnum(string value)
        {
            return value switch
            {
                "srt" => GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Srt,
                "webvtt" => GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.Webvtt,
                _ => null,
            };
        }
    }
}