//HintName: G.Models.BetaResponseThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: thinking
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseThinkingBlockType value)
        {
            return value switch
            {
                BetaResponseThinkingBlockType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => BetaResponseThinkingBlockType.Thinking,
                _ => null,
            };
        }
    }
}