//HintName: G.Models.QueryStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum QueryStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_results")]
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_chunk")]
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_end")]
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="factual_consistency_score")]
        FactualConsistencyScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_info")]
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end")]
        End,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                QueryStreamedResponseDiscriminatorType.SearchResults => "search_results",
                QueryStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                QueryStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                QueryStreamedResponseDiscriminatorType.FactualConsistencyScore => "factual_consistency_score",
                QueryStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
                QueryStreamedResponseDiscriminatorType.Error => "error",
                QueryStreamedResponseDiscriminatorType.End => "end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "search_results" => QueryStreamedResponseDiscriminatorType.SearchResults,
                "generation_chunk" => QueryStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_end" => QueryStreamedResponseDiscriminatorType.GenerationEnd,
                "factual_consistency_score" => QueryStreamedResponseDiscriminatorType.FactualConsistencyScore,
                "generation_info" => QueryStreamedResponseDiscriminatorType.GenerationInfo,
                "error" => QueryStreamedResponseDiscriminatorType.Error,
                "end" => QueryStreamedResponseDiscriminatorType.End,
                _ => null,
            };
        }
    }
}