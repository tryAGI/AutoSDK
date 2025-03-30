//HintName: G.Models.QueryHistorySpanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryHistorySpanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Rephrase,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Generation,
        /// <summary>
        /// 
        /// </summary>
        Fcs,
        /// <summary>
        /// 
        /// </summary>
        RewrittenQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryHistorySpanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryHistorySpanDiscriminatorType value)
        {
            return value switch
            {
                QueryHistorySpanDiscriminatorType.Rephrase => "rephrase",
                QueryHistorySpanDiscriminatorType.Search => "search",
                QueryHistorySpanDiscriminatorType.Rerank => "rerank",
                QueryHistorySpanDiscriminatorType.Generation => "generation",
                QueryHistorySpanDiscriminatorType.Fcs => "fcs",
                QueryHistorySpanDiscriminatorType.RewrittenQuery => "rewritten_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryHistorySpanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "rephrase" => QueryHistorySpanDiscriminatorType.Rephrase,
                "search" => QueryHistorySpanDiscriminatorType.Search,
                "rerank" => QueryHistorySpanDiscriminatorType.Rerank,
                "generation" => QueryHistorySpanDiscriminatorType.Generation,
                "fcs" => QueryHistorySpanDiscriminatorType.Fcs,
                "rewritten_query" => QueryHistorySpanDiscriminatorType.RewrittenQuery,
                _ => null,
            };
        }
    }
}