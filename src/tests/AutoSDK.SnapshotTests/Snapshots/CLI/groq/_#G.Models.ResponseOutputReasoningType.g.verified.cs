//HintName: G.Models.ResponseOutputReasoningType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the reasoning output. Always `reasoning`.
    /// </summary>
    public enum ResponseOutputReasoningType
    {
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputReasoningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputReasoningType value)
        {
            return value switch
            {
                ResponseOutputReasoningType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputReasoningType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ResponseOutputReasoningType.Reasoning,
                _ => null,
            };
        }
    }
}