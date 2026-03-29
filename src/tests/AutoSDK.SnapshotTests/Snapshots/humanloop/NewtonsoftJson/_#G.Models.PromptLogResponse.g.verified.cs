//HintName: G.Models.PromptLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptLogResponse
    {
        /// <summary>
        /// Unique identifier for the Log.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
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
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerLatency")]
        public double? ProviderLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLogResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the Log.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="output"></param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="outputCost"></param>
        /// <param name="finishReason"></param>
        /// <param name="messages"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="providerLatency"></param>
        /// <param name="error"></param>
        /// <param name="traceParentId"></param>
        /// <param name="updatedAt"></param>
        public PromptLogResponse(
            string id,
            global::System.DateTime createdAt,
            string? promptId,
            string? versionId,
            string? output,
            global::G.ChatMessage? outputMessage,
            int? promptTokens,
            int? outputTokens,
            double? promptCost,
            double? outputCost,
            string? finishReason,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages,
            object? inputs,
            string? source,
            object? metadata,
            double? providerLatency,
            string? error,
            string? traceParentId,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptId = promptId;
            this.VersionId = versionId;
            this.Output = output;
            this.OutputMessage = outputMessage;
            this.PromptTokens = promptTokens;
            this.OutputTokens = outputTokens;
            this.PromptCost = promptCost;
            this.OutputCost = outputCost;
            this.FinishReason = finishReason;
            this.Messages = messages;
            this.Inputs = inputs;
            this.Source = source;
            this.Metadata = metadata;
            this.ProviderLatency = providerLatency;
            this.Error = error;
            this.TraceParentId = traceParentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLogResponse" /> class.
        /// </summary>
        public PromptLogResponse()
        {
        }
    }
}