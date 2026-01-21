//HintName: G.Models.MessageStopReason2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStopReason2
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
    public static class MessageStopReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStopReason2 value)
        {
            return value switch
            {
                MessageStopReason2.EndTurn => "end_turn",
                MessageStopReason2.MaxTokens => "max_tokens",
                MessageStopReason2.StopSequence => "stop_sequence",
                MessageStopReason2.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStopReason2? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessageStopReason2.EndTurn,
                "max_tokens" => MessageStopReason2.MaxTokens,
                "stop_sequence" => MessageStopReason2.StopSequence,
                "tool_use" => MessageStopReason2.ToolUse,
                _ => null,
            };
        }
    }
}