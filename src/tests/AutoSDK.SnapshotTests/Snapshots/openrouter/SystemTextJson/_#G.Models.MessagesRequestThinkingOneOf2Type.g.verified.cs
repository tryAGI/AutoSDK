//HintName: G.Models.MessagesRequestThinkingOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestThinkingOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Adaptive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingOneOf2Type value)
        {
            return value switch
            {
                MessagesRequestThinkingOneOf2Type.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => MessagesRequestThinkingOneOf2Type.Adaptive,
                _ => null,
            };
        }
    }
}