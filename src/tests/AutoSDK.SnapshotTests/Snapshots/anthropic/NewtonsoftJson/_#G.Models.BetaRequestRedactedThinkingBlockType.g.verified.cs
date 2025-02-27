//HintName: G.Models.BetaRequestRedactedThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestRedactedThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="redacted_thinking")]
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestRedactedThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestRedactedThinkingBlockType value)
        {
            return value switch
            {
                BetaRequestRedactedThinkingBlockType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestRedactedThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => BetaRequestRedactedThinkingBlockType.RedactedThinking,
                _ => null,
            };
        }
    }
}