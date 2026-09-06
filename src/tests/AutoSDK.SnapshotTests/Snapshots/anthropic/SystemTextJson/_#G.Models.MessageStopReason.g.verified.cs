//HintName: G.Models.MessageStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageStopReason
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
    public static class MessageStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStopReason value)
        {
            return value switch
            {
                MessageStopReason.EndTurn => "end_turn",
                MessageStopReason.MaxTokens => "max_tokens",
                MessageStopReason.StopSequence => "stop_sequence",
                MessageStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessageStopReason.EndTurn,
                "max_tokens" => MessageStopReason.MaxTokens,
                "stop_sequence" => MessageStopReason.StopSequence,
                "tool_use" => MessageStopReason.ToolUse,
                _ => null,
            };
        }
    }
}