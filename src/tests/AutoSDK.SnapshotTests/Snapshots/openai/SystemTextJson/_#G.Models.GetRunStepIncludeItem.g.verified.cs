//HintName: G.Models.GetRunStepIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRunStepIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        StepDetailsToolCallsAnyFileSearchResultsAnyContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRunStepIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRunStepIncludeItem value)
        {
            return value switch
            {
                GetRunStepIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent => "step_details.tool_calls[*].file_search.results[*].content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRunStepIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "step_details.tool_calls[*].file_search.results[*].content" => GetRunStepIncludeItem.StepDetailsToolCallsAnyFileSearchResultsAnyContent,
                _ => null,
            };
        }
    }
}