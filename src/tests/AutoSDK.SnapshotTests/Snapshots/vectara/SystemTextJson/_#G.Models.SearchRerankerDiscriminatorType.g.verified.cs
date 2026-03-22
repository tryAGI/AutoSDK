//HintName: G.Models.SearchRerankerDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRerankerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        CustomerReranker,
        /// <summary>
        /// 
        /// </summary>
        Mmr,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Userfn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRerankerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRerankerDiscriminatorType value)
        {
            return value switch
            {
                SearchRerankerDiscriminatorType.Chain => "chain",
                SearchRerankerDiscriminatorType.CustomerReranker => "customer_reranker",
                SearchRerankerDiscriminatorType.Mmr => "mmr",
                SearchRerankerDiscriminatorType.None => "none",
                SearchRerankerDiscriminatorType.Userfn => "userfn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRerankerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chain" => SearchRerankerDiscriminatorType.Chain,
                "customer_reranker" => SearchRerankerDiscriminatorType.CustomerReranker,
                "mmr" => SearchRerankerDiscriminatorType.Mmr,
                "none" => SearchRerankerDiscriminatorType.None,
                "userfn" => SearchRerankerDiscriminatorType.Userfn,
                _ => null,
            };
        }
    }
}