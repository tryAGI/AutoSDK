//HintName: G.Models.QueryHistorySpanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum QueryHistorySpanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fcs")]
        Fcs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation")]
        Generation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rephrase")]
        Rephrase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rewritten_query")]
        RewrittenQuery,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search")]
        Search,
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
                QueryHistorySpanDiscriminatorType.Fcs => "fcs",
                QueryHistorySpanDiscriminatorType.Generation => "generation",
                QueryHistorySpanDiscriminatorType.Rephrase => "rephrase",
                QueryHistorySpanDiscriminatorType.Rerank => "rerank",
                QueryHistorySpanDiscriminatorType.RewrittenQuery => "rewritten_query",
                QueryHistorySpanDiscriminatorType.Search => "search",
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
                "fcs" => QueryHistorySpanDiscriminatorType.Fcs,
                "generation" => QueryHistorySpanDiscriminatorType.Generation,
                "rephrase" => QueryHistorySpanDiscriminatorType.Rephrase,
                "rerank" => QueryHistorySpanDiscriminatorType.Rerank,
                "rewritten_query" => QueryHistorySpanDiscriminatorType.RewrittenQuery,
                "search" => QueryHistorySpanDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}