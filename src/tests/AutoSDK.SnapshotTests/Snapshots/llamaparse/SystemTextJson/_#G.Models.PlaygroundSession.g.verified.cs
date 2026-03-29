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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_params_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LlmParamsId { get; set; }

        /// <summary>
        /// LLM parameters last used in this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_params")]
        public global::G.LLMParameters? LlmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_params_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RetrievalParamsId { get; set; }

        /// <summary>
        /// Preset retrieval parameters last used in this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_params")]
        public global::G.PresetRetrievalParams? RetrievalParams { get; set; }

        /// <summary>
        /// Chat message history for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? ChatMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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