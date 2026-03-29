//HintName: G.Models.TurnTokenDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role of this turn: 'assistant' for LLM generations (trainable), 'tool' for tool results (non-trainable).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TurnTokenDataRole
    {
        /// <summary>
        /// 'assistant' for LLM generations (trainable), 'tool' for tool results (non-trainable).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 'assistant' for LLM generations (trainable), 'tool' for tool results (non-trainable).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnTokenDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnTokenDataRole value)
        {
            return value switch
            {
                TurnTokenDataRole.Assistant => "assistant",
                TurnTokenDataRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnTokenDataRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TurnTokenDataRole.Assistant,
                "tool" => TurnTokenDataRole.Tool,
                _ => null,
            };
        }
    }
}