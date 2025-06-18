//HintName: G.Models.ResponseReasoningDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.reasoning.done'.
    /// </summary>
    public enum ResponseReasoningDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningDoneEventType value)
        {
            return value switch
            {
                ResponseReasoningDoneEventType.ResponseReasoningDone => "response.reasoning.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning.done" => ResponseReasoningDoneEventType.ResponseReasoningDone,
                _ => null,
            };
        }
    }
}