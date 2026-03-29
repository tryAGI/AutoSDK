//HintName: G.Models.PromptLogRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to log a Prompt call.
    /// </summary>
    public sealed partial class PromptLogRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Unique identifier for the Run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputMessage")]
        public global::G.ChatMessage? OutputMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptCost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCost")]
        public double? OutputCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Messages { get; set; }

        /// <summary>
        /// Request to create or update a Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptRequest? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerLatency")]
        public double? ProviderLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDatapointId")]
        public string? SourceDatapointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logId")]
        public string? LogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLogRequest" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="runId">
        /// Unique identifier for the Run.
        /// </param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="outputCost"></param>
        /// <param name="finishReason"></param>
        /// <param name="messages"></param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="output"></param>
        /// <param name="createdAt"></param>
        /// <param name="error"></param>
        /// <param name="providerLatency"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceDatapointId"></param>
        /// <param name="traceParentId"></param>
        /// <param name="user"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptLogRequest(
            string? versionId,
            string? environment,
            string? runId,
            string? path,
            string? id,
            global::G.ChatMessage? outputMessage,
            int? promptTokens,
            int? reasoningTokens,
            int? outputTokens,
            double? promptCost,
            double? outputCost,
            string? finishReason,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages,
            global::G.PromptRequest? prompt,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            string? output,
            global::System.DateTime? createdAt,
            string? error,
            double? providerLatency,
            object? inputs,
            string? source,
            object? metadata,
            string? sourceDatapointId,
            string? traceParentId,
            string? user,
            bool? save,
            string? logId)
        {
            this.VersionId = versionId;
            this.Environment = environment;
            this.RunId = runId;
            this.Path = path;
            this.Id = id;
            this.OutputMessage = outputMessage;
            this.PromptTokens = promptTokens;
            this.ReasoningTokens = reasoningTokens;
            this.OutputTokens = outputTokens;
            this.PromptCost = promptCost;
            this.OutputCost = outputCost;
            this.FinishReason = finishReason;
            this.Messages = messages;
            this.Prompt = prompt;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Output = output;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.ProviderLatency = providerLatency;
            this.Inputs = inputs;
            this.Source = source;
            this.Metadata = metadata;
            this.SourceDatapointId = sourceDatapointId;
            this.TraceParentId = traceParentId;
            this.User = user;
            this.Save = save;
            this.LogId = logId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLogRequest" /> class.
        /// </summary>
        public PromptLogRequest()
        {
        }
    }
}