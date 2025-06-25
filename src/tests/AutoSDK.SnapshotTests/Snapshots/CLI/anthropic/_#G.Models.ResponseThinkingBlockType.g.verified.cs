//HintName: G.Models.ResponseThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: thinking
    /// </summary>
    public enum ResponseThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseThinkingBlockType value)
        {
            return value switch
            {
                ResponseThinkingBlockType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => ResponseThinkingBlockType.Thinking,
                _ => null,
            };
        }
    }
}