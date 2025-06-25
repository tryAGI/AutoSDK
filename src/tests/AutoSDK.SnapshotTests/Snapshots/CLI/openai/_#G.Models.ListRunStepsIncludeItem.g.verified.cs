//HintName: G.Models.ListRunStepsIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRunStepsIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        StepDetailsToolCallsAnyFileSearchResultsAnyContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRunStepsIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRunStepsIncludeItem value)
        {
            return value switch
            {
                ListRunStepsIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent => "step_details.tool_calls[*].file_search.results[*].content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRunStepsIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "step_details.tool_calls[*].file_search.results[*].content" => ListRunStepsIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent,
                _ => null,
            };
        }
    }
}