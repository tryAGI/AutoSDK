//HintName: G.Models.MessageDeltaStopReason2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageDeltaStopReason2
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
    public static class MessageDeltaStopReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaStopReason2 value)
        {
            return value switch
            {
                MessageDeltaStopReason2.EndTurn => "end_turn",
                MessageDeltaStopReason2.MaxTokens => "max_tokens",
                MessageDeltaStopReason2.StopSequence => "stop_sequence",
                MessageDeltaStopReason2.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaStopReason2? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessageDeltaStopReason2.EndTurn,
                "max_tokens" => MessageDeltaStopReason2.MaxTokens,
                "stop_sequence" => MessageDeltaStopReason2.StopSequence,
                "tool_use" => MessageDeltaStopReason2.ToolUse,
                _ => null,
            };
        }
    }
}