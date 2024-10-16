//HintName: G.Models.SearchRerankerDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRerankerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer_reranker")]
        CustomerReranker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="userfn")]
        Userfn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mmr")]
        Mmr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chain")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
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
                SearchRerankerDiscriminatorType.CustomerReranker => "customer_reranker",
                SearchRerankerDiscriminatorType.Userfn => "userfn",
                SearchRerankerDiscriminatorType.Mmr => "mmr",
                SearchRerankerDiscriminatorType.Chain => "chain",
                SearchRerankerDiscriminatorType.None => "none",
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
                "customer_reranker" => SearchRerankerDiscriminatorType.CustomerReranker,
                "userfn" => SearchRerankerDiscriminatorType.Userfn,
                "mmr" => SearchRerankerDiscriminatorType.Mmr,
                "chain" => SearchRerankerDiscriminatorType.Chain,
                "none" => SearchRerankerDiscriminatorType.None,
                _ => null,
            };
        }
    }
}