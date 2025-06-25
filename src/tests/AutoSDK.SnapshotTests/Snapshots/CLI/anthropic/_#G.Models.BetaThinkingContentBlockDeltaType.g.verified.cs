//HintName: G.Models.BetaThinkingContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: thinking_delta
    /// </summary>
    public enum BetaThinkingContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingContentBlockDeltaType value)
        {
            return value switch
            {
                BetaThinkingContentBlockDeltaType.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "thinking_delta" => BetaThinkingContentBlockDeltaType.ThinkingDelta,
                _ => null,
            };
        }
    }
}