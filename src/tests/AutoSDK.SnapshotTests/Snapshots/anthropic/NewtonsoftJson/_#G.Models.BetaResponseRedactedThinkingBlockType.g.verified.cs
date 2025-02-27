//HintName: G.Models.BetaResponseRedactedThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: redacted_thinking
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseRedactedThinkingBlockType
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
    public static class BetaResponseRedactedThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseRedactedThinkingBlockType value)
        {
            return value switch
            {
                BetaResponseRedactedThinkingBlockType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseRedactedThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => BetaResponseRedactedThinkingBlockType.RedactedThinking,
                _ => null,
            };
        }
    }
}