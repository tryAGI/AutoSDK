//HintName: G.Models.BetaRequestThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestThinkingBlockType value)
        {
            return value switch
            {
                BetaRequestThinkingBlockType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => BetaRequestThinkingBlockType.Thinking,
                _ => null,
            };
        }
    }
}