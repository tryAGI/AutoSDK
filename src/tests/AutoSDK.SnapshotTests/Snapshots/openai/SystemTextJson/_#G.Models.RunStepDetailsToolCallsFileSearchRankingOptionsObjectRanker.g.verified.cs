//HintName: G.Models.RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranker used for the file search.
    /// </summary>
    public enum RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker
    {
        /// <summary>
        /// 
        /// </summary>
        Default20240821,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDetailsToolCallsFileSearchRankingOptionsObjectRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker value)
        {
            return value switch
            {
                RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker.Default20240821 => "default_2024_08_21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker? ToEnum(string value)
        {
            return value switch
            {
                "default_2024_08_21" => RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker.Default20240821,
                _ => null,
            };
        }
    }
}