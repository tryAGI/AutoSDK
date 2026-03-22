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
        End,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        FactualConsistencyScore,
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
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
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
                QueryStreamedResponseDiscriminatorType.End => "end",
                QueryStreamedResponseDiscriminatorType.Error => "error",
                QueryStreamedResponseDiscriminatorType.FactualConsistencyScore => "factual_consistency_score",
                QueryStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                QueryStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                QueryStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
                QueryStreamedResponseDiscriminatorType.SearchResults => "search_results",
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
                "end" => QueryStreamedResponseDiscriminatorType.End,
                "error" => QueryStreamedResponseDiscriminatorType.Error,
                "factual_consistency_score" => QueryStreamedResponseDiscriminatorType.FactualConsistencyScore,
                "generation_chunk" => QueryStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_end" => QueryStreamedResponseDiscriminatorType.GenerationEnd,
                "generation_info" => QueryStreamedResponseDiscriminatorType.GenerationInfo,
                "search_results" => QueryStreamedResponseDiscriminatorType.SearchResults,
                _ => null,
            };
        }
    }
}