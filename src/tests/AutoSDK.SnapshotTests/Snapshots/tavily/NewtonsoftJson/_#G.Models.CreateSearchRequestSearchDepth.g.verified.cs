//HintName: G.Models.CreateSearchRequestSearchDepth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the latency vs. relevance tradeoff and how `results[].content` is generated:<br/>
    /// - `advanced`: Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
    /// - `basic`: A balanced option for relevance and latency. Ideal for general-purpose searches. Returns one NLP summary per URL.<br/>
    /// - `fast`: Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
    /// - `ultra-fast`: Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.<br/>
    /// **Cost**:<br/>
    /// - `basic`, `fast`, `ultra-fast`: 1 API Credit<br/>
    /// - `advanced`: 2 API Credits<br/>
    /// See [Search Best Practices](/documentation/best-practices/best-practices-search#search-depth) for guidance on choosing the right search depth.<br/>
    /// Default Value: basic
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSearchRequestSearchDepth
    {
        /// <summary>
        /// Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced")]
        Advanced,
        /// <summary>
        /// A balanced option for relevance and latency. Ideal for general-purpose searches. Returns one NLP summary per URL.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra-fast")]
        UltraFast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSearchRequestSearchDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestSearchDepth value)
        {
            return value switch
            {
                CreateSearchRequestSearchDepth.Advanced => "advanced",
                CreateSearchRequestSearchDepth.Basic => "basic",
                CreateSearchRequestSearchDepth.Fast => "fast",
                CreateSearchRequestSearchDepth.UltraFast => "ultra-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestSearchDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateSearchRequestSearchDepth.Advanced,
                "basic" => CreateSearchRequestSearchDepth.Basic,
                "fast" => CreateSearchRequestSearchDepth.Fast,
                "ultra-fast" => CreateSearchRequestSearchDepth.UltraFast,
                _ => null,
            };
        }
    }
}