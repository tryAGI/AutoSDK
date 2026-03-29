//HintName: G.Models.ResponseObj.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseObj
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public object Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptCacheWriteTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptCacheWriteTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptCacheReadTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptCacheReadTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delayMs", Required = global::Newtonsoft.Json.Required.Always)]
        public double DelayMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObj" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="createdAt"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="promptCacheWriteTokens"></param>
        /// <param name="promptCacheReadTokens"></param>
        /// <param name="delayMs"></param>
        /// <param name="model"></param>
        public ResponseObj(
            object body,
            string createdAt,
            double completionTokens,
            double promptTokens,
            double promptCacheWriteTokens,
            double promptCacheReadTokens,
            double delayMs,
            string model)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.PromptCacheWriteTokens = promptCacheWriteTokens;
            this.PromptCacheReadTokens = promptCacheReadTokens;
            this.DelayMs = delayMs;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObj" /> class.
        /// </summary>
        public ResponseObj()
        {
        }
    }
}