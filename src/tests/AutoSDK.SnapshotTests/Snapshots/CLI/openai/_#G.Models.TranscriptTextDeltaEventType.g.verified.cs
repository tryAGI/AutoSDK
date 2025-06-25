//HintName: G.Models.TranscriptTextDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `transcript.text.delta`.
    /// </summary>
    public enum TranscriptTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptTextDeltaEventType value)
        {
            return value switch
            {
                TranscriptTextDeltaEventType.TranscriptTextDelta => "transcript.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.delta" => TranscriptTextDeltaEventType.TranscriptTextDelta,
                _ => null,
            };
        }
    }
}