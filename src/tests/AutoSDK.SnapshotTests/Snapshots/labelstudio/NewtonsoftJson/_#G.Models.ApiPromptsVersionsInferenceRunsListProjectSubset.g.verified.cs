//HintName: G.Models.ApiPromptsVersionsInferenceRunsListProjectSubset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiPromptsVersionsInferenceRunsListProjectSubset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="All")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HasGT")]
        HasGT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Sample")]
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