//HintName: G.Models.PartialTranscriptPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'partial_transcript'.
    /// </summary>
    public enum PartialTranscriptPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        PartialTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialTranscriptPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialTranscriptPayloadMessageType value)
        {
            return value switch
            {
                PartialTranscriptPayloadMessageType.PartialTranscript => "partial_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialTranscriptPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "partial_transcript" => PartialTranscriptPayloadMessageType.PartialTranscript,
                _ => null,
            };
        }
    }
}