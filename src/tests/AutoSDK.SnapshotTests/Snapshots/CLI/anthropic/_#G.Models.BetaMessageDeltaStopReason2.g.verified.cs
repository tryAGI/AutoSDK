//HintName: G.Models.BetaMessageDeltaStopReason2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMessageDeltaStopReason2
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
    public static class BetaMessageDeltaStopReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageDeltaStopReason2 value)
        {
            return value switch
            {
                BetaMessageDeltaStopReason2.EndTurn => "end_turn",
                BetaMessageDeltaStopReason2.MaxTokens => "max_tokens",
                BetaMessageDeltaStopReason2.StopSequence => "stop_sequence",
                BetaMessageDeltaStopReason2.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageDeltaStopReason2? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaMessageDeltaStopReason2.EndTurn,
                "max_tokens" => BetaMessageDeltaStopReason2.MaxTokens,
                "stop_sequence" => BetaMessageDeltaStopReason2.StopSequence,
                "tool_use" => BetaMessageDeltaStopReason2.ToolUse,
                _ => null,
            };
        }
    }
}