//HintName: G.Models.BaseMessagesResultStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultStopReason
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
        [global::System.Runtime.Serialization.EnumMember(Value="pause_turn")]
        PauseTurn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refusal")]
        Refusal,
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
    public static class BaseMessagesResultStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultStopReason value)
        {
            return value switch
            {
                BaseMessagesResultStopReason.EndTurn => "end_turn",
                BaseMessagesResultStopReason.MaxTokens => "max_tokens",
                BaseMessagesResultStopReason.PauseTurn => "pause_turn",
                BaseMessagesResultStopReason.Refusal => "refusal",
                BaseMessagesResultStopReason.StopSequence => "stop_sequence",
                BaseMessagesResultStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BaseMessagesResultStopReason.EndTurn,
                "max_tokens" => BaseMessagesResultStopReason.MaxTokens,
                "pause_turn" => BaseMessagesResultStopReason.PauseTurn,
                "refusal" => BaseMessagesResultStopReason.Refusal,
                "stop_sequence" => BaseMessagesResultStopReason.StopSequence,
                "tool_use" => BaseMessagesResultStopReason.ToolUse,
                _ => null,
            };
        }
    }
}