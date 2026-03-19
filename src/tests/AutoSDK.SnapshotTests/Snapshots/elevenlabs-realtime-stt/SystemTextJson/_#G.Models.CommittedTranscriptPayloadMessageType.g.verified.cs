//HintName: G.Models.CommittedTranscriptPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'committed_transcript'.
    /// </summary>
    public enum CommittedTranscriptPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CommittedTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommittedTranscriptPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommittedTranscriptPayloadMessageType value)
        {
            return value switch
            {
                CommittedTranscriptPayloadMessageType.CommittedTranscript => "committed_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommittedTranscriptPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "committed_transcript" => CommittedTranscriptPayloadMessageType.CommittedTranscript,
                _ => null,
            };
        }
    }
}