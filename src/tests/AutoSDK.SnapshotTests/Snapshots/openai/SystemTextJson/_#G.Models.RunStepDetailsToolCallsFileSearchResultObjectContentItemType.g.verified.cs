//HintName: G.Models.RunStepDetailsToolCallsFileSearchResultObjectContentItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content.
    /// </summary>
    public enum RunStepDetailsToolCallsFileSearchResultObjectContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsFileSearchResultObjectContentItemType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsFileSearchResultObjectContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsFileSearchResultObjectContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RunStepDetailsToolCallsFileSearchResultObjectContentItemType.Text,
                _ => null,
            };
        }
    }
}