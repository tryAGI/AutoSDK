//HintName: G.Models.BetaMessageDeltaStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageDeltaStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end_turn")]
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_tokens")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop_sequence")]
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageDeltaStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageDeltaStopReason value)
        {
            return value switch
            {
                BetaMessageDeltaStopReason.EndTurn => "end_turn",
                BetaMessageDeltaStopReason.MaxTokens => "max_tokens",
                BetaMessageDeltaStopReason.StopSequence => "stop_sequence",
                BetaMessageDeltaStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageDeltaStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaMessageDeltaStopReason.EndTurn,
                "max_tokens" => BetaMessageDeltaStopReason.MaxTokens,
                "stop_sequence" => BetaMessageDeltaStopReason.StopSequence,
                "tool_use" => BetaMessageDeltaStopReason.ToolUse,
                _ => null,
            };
        }
    }
}