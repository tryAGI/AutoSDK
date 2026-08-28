//HintName: G.Models.BaseMessagesResultUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double InputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double OutputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_creation_input_tokens")]
        public double? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_read_input_tokens")]
        public double? CacheReadInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_creation")]
        public global::G.BaseMessagesResultUsageCacheCreation? CacheCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_geo")]
        public string? InferenceGeo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_tool_use")]
        public global::G.BaseMessagesResultUsageServerToolUse? ServerToolUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public global::G.BaseMessagesResultUsageServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public global::G.BaseMessagesResultUsageSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="cacheCreation"></param>
        /// <param name="inferenceGeo"></param>
        /// <param name="serverToolUse"></param>
        /// <param name="serviceTier"></param>
        /// <param name="speed"></param>
        public BaseMessagesResultUsage(
            double inputTokens,
            double outputTokens,
            double? cacheCreationInputTokens,
            double? cacheReadInputTokens,
            global::G.BaseMessagesResultUsageCacheCreation? cacheCreation,
            string? inferenceGeo,
            global::G.BaseMessagesResultUsageServerToolUse? serverToolUse,
            global::G.BaseMessagesResultUsageServiceTier? serviceTier,
            global::G.BaseMessagesResultUsageSpeed? speed)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation = cacheCreation;
            this.InferenceGeo = inferenceGeo;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsage" /> class.
        /// </summary>
        public BaseMessagesResultUsage()
        {
        }

    }
}