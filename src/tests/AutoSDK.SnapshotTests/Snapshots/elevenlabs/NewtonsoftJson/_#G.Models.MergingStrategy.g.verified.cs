//HintName: G.Models.MergingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strategy for merging results from multiple sources.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MergingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rank_fusion")]
        RankFusion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_k_per_source")]
        TopKPerSource,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weighted_interleave")]
        WeightedInterleave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergingStrategy value)
        {
            return value switch
            {
                MergingStrategy.RankFusion => "rank_fusion",
                MergingStrategy.TopKPerSource => "top_k_per_source",
                MergingStrategy.WeightedInterleave => "weighted_interleave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "rank_fusion" => MergingStrategy.RankFusion,
                "top_k_per_source" => MergingStrategy.TopKPerSource,
                "weighted_interleave" => MergingStrategy.WeightedInterleave,
                _ => null,
            };
        }
    }
}