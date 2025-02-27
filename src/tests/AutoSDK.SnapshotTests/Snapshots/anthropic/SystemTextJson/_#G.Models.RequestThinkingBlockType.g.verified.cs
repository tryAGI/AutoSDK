//HintName: G.Models.RequestThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestThinkingBlockType value)
        {
            return value switch
            {
                RequestThinkingBlockType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => RequestThinkingBlockType.Thinking,
                _ => null,
            };
        }
    }
}