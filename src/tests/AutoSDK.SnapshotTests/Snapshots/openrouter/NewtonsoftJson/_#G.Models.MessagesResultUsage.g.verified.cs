//HintName: G.Models.MessagesResultUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsage
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
        [global::Newtonsoft.Json.JsonProperty("cache_creation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.MessagesResultUsageCacheCreation, object> CacheCreation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_geo")]
        public string? InferenceGeo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_tool_use", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.MessagesResultUsageServerToolUse, object> ServerToolUse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public global::G.OneOf<global::G.MessagesResultUsageSpeed?, object>? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_details")]
        public global::G.OneOf<global::G.MessagesResultUsageCostDetails, object>? CostDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreation"></param>
        /// <param name="serverToolUse"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inferenceGeo"></param>
        /// <param name="serviceTier"></param>
        /// <param name="speed"></param>
        /// <param name="cost"></param>
        /// <param name="isByok"></param>
        /// <param name="costDetails"></param>
        public MessagesResultUsage(
            double inputTokens,
            double outputTokens,
            global::G.OneOf<global::G.MessagesResultUsageCacheCreation, object> cacheCreation,
            global::G.OneOf<global::G.MessagesResultUsageServerToolUse, object> serverToolUse,
            double? cacheCreationInputTokens,
            double? cacheReadInputTokens,
            string? inferenceGeo,
            string? serviceTier,
            global::G.OneOf<global::G.MessagesResultUsageSpeed?, object>? speed,
            double? cost,
            bool? isByok,
            global::G.OneOf<global::G.MessagesResultUsageCostDetails, object>? costDetails)
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
            this.Cost = cost;
            this.IsByok = isByok;
            this.CostDetails = costDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsage" /> class.
        /// </summary>
        public MessagesResultUsage()
        {
        }
    }
}