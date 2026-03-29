//HintName: G.Models.PromptCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from calling a Prompt.
    /// </summary>
    public sealed partial class PromptCallResponse
    {
        /// <summary>
        /// Unique identifier for the log.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Version ID of the Prompt used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Generated text output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputMessage")]
        public global::G.ChatMessage? OutputMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptCost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputCost")]
        public double? OutputCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishReason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Provider latency in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerLatency")]
        public double? ProviderLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the log.
        /// </param>
        /// <param name="versionId">
        /// Version ID of the Prompt used.
        /// </param>
        /// <param name="output">
        /// Generated text output.
        /// </param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="outputCost"></param>
        /// <param name="finishReason"></param>
        /// <param name="inputs"></param>
        /// <param name="providerLatency">
        /// Provider latency in seconds.
        /// </param>
        /// <param name="createdAt"></param>
        public PromptCallResponse(
            string id,
            string? versionId,
            string? output,
            global::G.ChatMessage? outputMessage,
            int? promptTokens,
            int? outputTokens,
            double? promptCost,
            double? outputCost,
            string? finishReason,
            object? inputs,
            double? providerLatency,
            global::System.DateTime? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId;
            this.Output = output;
            this.OutputMessage = outputMessage;
            this.PromptTokens = promptTokens;
            this.OutputTokens = outputTokens;
            this.PromptCost = promptCost;
            this.OutputCost = outputCost;
            this.FinishReason = finishReason;
            this.Inputs = inputs;
            this.ProviderLatency = providerLatency;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallResponse" /> class.
        /// </summary>
        public PromptCallResponse()
        {
        }
    }
}