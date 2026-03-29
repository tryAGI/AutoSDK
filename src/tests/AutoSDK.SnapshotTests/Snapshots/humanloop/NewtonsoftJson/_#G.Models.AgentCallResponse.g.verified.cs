//HintName: G.Models.AgentCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("finishReason")]
        public string? FinishReason { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentCallResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="output"></param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="finishReason"></param>
        /// <param name="createdAt"></param>
        public AgentCallResponse(
            string id,
            string? versionId,
            string? output,
            global::G.ChatMessage? outputMessage,
            int? promptTokens,
            int? outputTokens,
            string? finishReason,
            global::System.DateTime? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId;
            this.Output = output;
            this.OutputMessage = outputMessage;
            this.PromptTokens = promptTokens;
            this.OutputTokens = outputTokens;
            this.FinishReason = finishReason;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallResponse" /> class.
        /// </summary>
        public AgentCallResponse()
        {
        }
    }
}