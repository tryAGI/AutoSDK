//HintName: G.Models.BetaMessageStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageStopReason
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
    public static class BetaMessageStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStopReason value)
        {
            return value switch
            {
                BetaMessageStopReason.EndTurn => "end_turn",
                BetaMessageStopReason.MaxTokens => "max_tokens",
                BetaMessageStopReason.StopSequence => "stop_sequence",
                BetaMessageStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaMessageStopReason.EndTurn,
                "max_tokens" => BetaMessageStopReason.MaxTokens,
                "stop_sequence" => BetaMessageStopReason.StopSequence,
                "tool_use" => BetaMessageStopReason.ToolUse,
                _ => null,
            };
        }
    }
}