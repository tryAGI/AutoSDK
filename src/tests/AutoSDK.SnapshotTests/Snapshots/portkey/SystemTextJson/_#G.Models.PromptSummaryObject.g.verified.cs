//HintName: G.Models.PromptSummaryObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptSummaryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptSummaryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptSummaryObject value)
        {
            return value switch
            {
                PromptSummaryObject.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptSummaryObject? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => PromptSummaryObject.Prompt,
                _ => null,
            };
        }
    }
}