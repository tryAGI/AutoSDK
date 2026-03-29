//HintName: G.Models.VectorStoreSearchRequestRankingOptionsRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreSearchRequestRankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default-2024-11-15")]
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreSearchRequestRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreSearchRequestRankingOptionsRanker value)
        {
            return value switch
            {
                VectorStoreSearchRequestRankingOptionsRanker.Auto => "auto",
                VectorStoreSearchRequestRankingOptionsRanker.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreSearchRequestRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => VectorStoreSearchRequestRankingOptionsRanker.Auto,
                "default-2024-11-15" => VectorStoreSearchRequestRankingOptionsRanker.Default20241115,
                _ => null,
            };
        }
    }
}