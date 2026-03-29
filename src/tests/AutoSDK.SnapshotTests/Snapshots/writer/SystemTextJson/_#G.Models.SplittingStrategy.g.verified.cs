//HintName: G.Models.SplittingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SplittingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        FastSplit,
        /// <summary>
        /// 
        /// </summary>
        HybridSplit,
        /// <summary>
        /// 
        /// </summary>
        LlmSplit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplittingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplittingStrategy value)
        {
            return value switch
            {
                SplittingStrategy.FastSplit => "fast_split",
                SplittingStrategy.HybridSplit => "hybrid_split",
                SplittingStrategy.LlmSplit => "llm_split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplittingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "fast_split" => SplittingStrategy.FastSplit,
                "hybrid_split" => SplittingStrategy.HybridSplit,
                "llm_split" => SplittingStrategy.LlmSplit,
                _ => null,
            };
        }
    }
}