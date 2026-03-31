//HintName: G.Models.PromptBlockDataCompletionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptBlockDataCompletionType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataCompletionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataCompletionType value)
        {
            return value switch
            {
                PromptBlockDataCompletionType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataCompletionType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => PromptBlockDataCompletionType.Completion,
                _ => null,
            };
        }
    }
}