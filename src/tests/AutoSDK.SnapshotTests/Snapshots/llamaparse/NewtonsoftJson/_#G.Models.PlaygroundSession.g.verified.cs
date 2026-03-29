//HintName: G.Models.PlaygroundSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A playground session for a user.
    /// </summary>
    public sealed partial class PlaygroundSession
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PipelineId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_params_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid LlmParamsId { get; set; } = default!;

        /// <summary>
        /// LLM parameters last used in this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_params")]
        public global::G.LLMParameters? LlmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_params_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RetrievalParamsId { get; set; } = default!;

        /// <summary>
        /// Preset retrieval parameters last used in this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_params")]
        public global::G.PresetRetrievalParams? RetrievalParams { get; set; }

        /// <summary>
        /// Chat message history for this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? ChatMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="pipelineId"></param>
        /// <param name="userId"></param>
        /// <param name="llmParamsId"></param>
        /// <param name="retrievalParamsId"></param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="llmParams">
        /// LLM parameters last used in this session.
        /// </param>
        /// <param name="retrievalParams">
        /// Preset retrieval parameters last used in this session.
        /// </param>
        /// <param name="chatMessages">
        /// Chat message history for this session.
        /// </param>
        public PlaygroundSession(
            global::System.Guid id,
            global::System.Guid pipelineId,
            string userId,
            global::System.Guid llmParamsId,
            global::System.Guid retrievalParamsId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.LLMParameters? llmParams,
            global::G.PresetRetrievalParams? retrievalParams,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? chatMessages)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PipelineId = pipelineId;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.LlmParamsId = llmParamsId;
            this.LlmParams = llmParams;
            this.RetrievalParamsId = retrievalParamsId;
            this.RetrievalParams = retrievalParams;
            this.ChatMessages = chatMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSession" /> class.
        /// </summary>
        public PlaygroundSession()
        {
        }
    }
}