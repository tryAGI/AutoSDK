//HintName: G.Models.MessageDeltaStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageDeltaStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaStopReason value)
        {
            return value switch
            {
                MessageDeltaStopReason.EndTurn => "end_turn",
                MessageDeltaStopReason.MaxTokens => "max_tokens",
                MessageDeltaStopReason.StopSequence => "stop_sequence",
                MessageDeltaStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessageDeltaStopReason.EndTurn,
                "max_tokens" => MessageDeltaStopReason.MaxTokens,
                "stop_sequence" => MessageDeltaStopReason.StopSequence,
                "tool_use" => MessageDeltaStopReason.ToolUse,
                _ => null,
            };
        }
    }
}