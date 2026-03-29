//HintName: G.Models.PromptConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptConditionType value)
        {
            return value switch
            {
                PromptConditionType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptConditionType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => PromptConditionType.Prompt,
                _ => null,
            };
        }
    }
}