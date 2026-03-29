//HintName: G.Models.OutputItemReasoningType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemReasoningType
    {
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemReasoningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemReasoningType value)
        {
            return value switch
            {
                OutputItemReasoningType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemReasoningType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => OutputItemReasoningType.Reasoning,
                _ => null,
            };
        }
    }
}