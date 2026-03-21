//HintName: G.Models.TranscriptResultPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptResultPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript_result")]
        TranscriptResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptResultPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptResultPayloadMessageType value)
        {
            return value switch
            {
                TranscriptResultPayloadMessageType.TranscriptResult => "transcript_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptResultPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript_result" => TranscriptResultPayloadMessageType.TranscriptResult,
                _ => null,
            };
        }
    }
}