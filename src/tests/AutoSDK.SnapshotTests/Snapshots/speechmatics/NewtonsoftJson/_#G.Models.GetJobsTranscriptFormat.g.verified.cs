//HintName: G.Models.GetJobsTranscriptFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetJobsTranscriptFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json-v2")]
        JsonV2,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJobsTranscriptFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsTranscriptFormat value)
        {
            return value switch
            {
                GetJobsTranscriptFormat.JsonV2 => "json-v2",
                GetJobsTranscriptFormat.Srt => "srt",
                GetJobsTranscriptFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsTranscriptFormat? ToEnum(string value)
        {
            return value switch
            {
                "json-v2" => GetJobsTranscriptFormat.JsonV2,
                "srt" => GetJobsTranscriptFormat.Srt,
                "txt" => GetJobsTranscriptFormat.Txt,
                _ => null,
            };
        }
    }
}