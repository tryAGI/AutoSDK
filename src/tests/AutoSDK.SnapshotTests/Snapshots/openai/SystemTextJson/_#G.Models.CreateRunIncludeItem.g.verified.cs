//HintName: G.Models.CreateRunIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRunIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        StepDetailsToolCallsAnyFileSearchResultsAnyContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunIncludeItem value)
        {
            return value switch
            {
                CreateRunIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent => "step_details.tool_calls[*].file_search.results[*].content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "step_details.tool_calls[*].file_search.results[*].content" => CreateRunIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent,
                _ => null,
            };
        }
    }
}