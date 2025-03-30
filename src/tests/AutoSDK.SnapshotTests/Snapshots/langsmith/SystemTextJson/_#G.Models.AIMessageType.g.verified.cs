//HintName: G.Models.AIMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: ai
    /// </summary>
    public enum AIMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageType value)
        {
            return value switch
            {
                AIMessageType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => AIMessageType.Ai,
                _ => null,
            };
        }
    }
}