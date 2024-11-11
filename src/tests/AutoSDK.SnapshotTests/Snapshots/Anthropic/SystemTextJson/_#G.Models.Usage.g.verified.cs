//HintName: G.Models.Usage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Billing and rate-limit usage.<br/>
    /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
    /// underlying cost to our systems.<br/>
    /// Under the hood, the API transforms requests into a format suitable for the<br/>
    /// model. The model's output then goes through a parsing stage before becoming an<br/>
    /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
    /// with the exact visible content of an API request or response.<br/>
    /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
    /// from Claude.
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// The number of input tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens used to create the cache entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The number of input tokens read from the cache.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens used to create the cache entry.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Usage(
            int inputTokens,
            int outputTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}