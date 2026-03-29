//HintName: G.Models.PromptPartialSummaryObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptPartialSummaryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptPartialSummaryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPartialSummaryObject value)
        {
            return value switch
            {
                PromptPartialSummaryObject.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPartialSummaryObject? ToEnum(string value)
        {
            return value switch
            {
                "partial" => PromptPartialSummaryObject.Partial,
                _ => null,
            };
        }
    }
}