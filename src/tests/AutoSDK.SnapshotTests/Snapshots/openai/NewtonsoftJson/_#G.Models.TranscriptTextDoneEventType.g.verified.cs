//HintName: G.Models.TranscriptTextDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `transcript.text.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptTextDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.text.done")]
        TranscriptTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptTextDoneEventType value)
        {
            return value switch
            {
                TranscriptTextDoneEventType.TranscriptTextDone => "transcript.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.done" => TranscriptTextDoneEventType.TranscriptTextDone,
                _ => null,
            };
        }
    }
}