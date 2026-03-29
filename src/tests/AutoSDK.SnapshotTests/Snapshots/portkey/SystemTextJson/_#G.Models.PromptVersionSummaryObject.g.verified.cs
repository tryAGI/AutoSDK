//HintName: G.Models.PromptVersionSummaryObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionSummaryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionSummaryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionSummaryObject value)
        {
            return value switch
            {
                PromptVersionSummaryObject.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionSummaryObject? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => PromptVersionSummaryObject.Prompt,
                _ => null,
            };
        }
    }
}