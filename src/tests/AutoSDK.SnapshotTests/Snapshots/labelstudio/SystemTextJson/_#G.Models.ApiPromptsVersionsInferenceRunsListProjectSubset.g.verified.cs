//HintName: G.Models.ApiPromptsVersionsInferenceRunsListProjectSubset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiPromptsVersionsInferenceRunsListProjectSubset
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        HasGT,
        /// <summary>
        /// 
        /// </summary>
        Sample,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiPromptsVersionsInferenceRunsListProjectSubsetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiPromptsVersionsInferenceRunsListProjectSubset value)
        {
            return value switch
            {
                ApiPromptsVersionsInferenceRunsListProjectSubset.All => "All",
                ApiPromptsVersionsInferenceRunsListProjectSubset.HasGT => "HasGT",
                ApiPromptsVersionsInferenceRunsListProjectSubset.Sample => "Sample",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiPromptsVersionsInferenceRunsListProjectSubset? ToEnum(string value)
        {
            return value switch
            {
                "All" => ApiPromptsVersionsInferenceRunsListProjectSubset.All,
                "HasGT" => ApiPromptsVersionsInferenceRunsListProjectSubset.HasGT,
                "Sample" => ApiPromptsVersionsInferenceRunsListProjectSubset.Sample,
                _ => null,
            };
        }
    }
}