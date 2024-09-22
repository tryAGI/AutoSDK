//HintName: G.Models.StopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that we stopped.<br/>
    /// This may be one the following values:<br/>
    /// - `"end_turn"`: the model reached a natural stopping point<br/>
    /// - `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
    /// - `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
    /// In non-streaming mode this value is always non-null. In streaming mode, it is<br/>
    /// null in the `message_start` event and non-null otherwise.
    /// </summary>
    public enum StopReason
    {
        /// <summary>
        /// the model reached a natural stopping point
        /// </summary>
        EndTurn,
        /// <summary>
        /// we exceeded the requested `max_tokens` or the model's maximum
        /// </summary>
        MaxTokens,
        /// <summary>
        /// one of your provided custom `stop_sequences` was generated
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
    public static class StopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopReason value)
        {
            return value switch
            {
                StopReason.EndTurn => "end_turn",
                StopReason.MaxTokens => "max_tokens",
                StopReason.StopSequence => "stop_sequence",
                StopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => StopReason.EndTurn,
                "max_tokens" => StopReason.MaxTokens,
                "stop_sequence" => StopReason.StopSequence,
                "tool_use" => StopReason.ToolUse,
                _ => null,
            };
        }
    }
}