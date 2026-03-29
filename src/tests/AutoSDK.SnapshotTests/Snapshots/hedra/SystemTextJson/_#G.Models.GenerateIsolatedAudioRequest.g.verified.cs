//HintName: G.Models.GenerateIsolatedAudioRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateIsolatedAudioRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional agent thread ID to associate this generation with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_thread_id")]
        public global::System.Guid? AgentThreadId { get; set; }

        /// <summary>
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GenerationIds { get; set; }

        /// <summary>
        /// Default Value: audio_isolation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the audio asset requiring sound isolation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AudioId { get; set; }

        /// <summary>
        /// The id of the model to use for audio isolation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AiModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateIsolatedAudioRequest" /> class.
        /// </summary>
        /// <param name="audioId">
        /// The id of the audio asset requiring sound isolation.
        /// </param>
        /// <param name="aiModelId">
        /// The id of the model to use for audio isolation.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="agentThreadId">
        /// Optional agent thread ID to associate this generation with.
        /// </param>
        /// <param name="generationId">
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </param>
        /// <param name="generationIds">
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </param>
        /// <param name="type">
        /// Default Value: audio_isolation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateIsolatedAudioRequest(
            global::System.Guid audioId,
            global::System.Guid aiModelId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AudioId = audioId;
            this.AiModelId = aiModelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateIsolatedAudioRequest" /> class.
        /// </summary>
        public GenerateIsolatedAudioRequest()
        {
        }
    }
}