//HintName: G.Models.BetaUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaUsage
    {
        /// <summary>
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </summary>
        /// <example>2095</example>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// The number of input tokens used to create the cache entry.<br/>
        /// Example: 2051
        /// </summary>
        /// <example>2051</example>
        [global::Newtonsoft.Json.JsonProperty("cache_creation_input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? CacheCreationInputTokens { get; set; } = default!;

        /// <summary>
        /// The number of input tokens read from the cache.<br/>
        /// Example: 2051
        /// </summary>
        /// <example>2051</example>
        [global::Newtonsoft.Json.JsonProperty("cache_read_input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? CacheReadInputTokens { get; set; } = default!;

        /// <summary>
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </summary>
        /// <example>503</example>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The number of input tokens used to create the cache entry.<br/>
        /// Example: 2051
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.<br/>
        /// Example: 2051
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </param>
        public BetaUsage(
            int inputTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            int outputTokens)
        {
            this.InputTokens = inputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        public BetaUsage()
        {
        }
    }
}