//HintName: G.Models.BetaMessageStopReason2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMessageStopReason2
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
    public static class BetaMessageStopReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStopReason2 value)
        {
            return value switch
            {
                BetaMessageStopReason2.EndTurn => "end_turn",
                BetaMessageStopReason2.MaxTokens => "max_tokens",
                BetaMessageStopReason2.StopSequence => "stop_sequence",
                BetaMessageStopReason2.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStopReason2? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaMessageStopReason2.EndTurn,
                "max_tokens" => BetaMessageStopReason2.MaxTokens,
                "stop_sequence" => BetaMessageStopReason2.StopSequence,
                "tool_use" => BetaMessageStopReason2.ToolUse,
                _ => null,
            };
        }
    }
}