//HintName: G.Models.QueryStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        FactualConsistencyScore,
        /// <summary>
        /// 
        /// </summary>
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
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