//HintName: G.Models.GenerateVideoWithAudioRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Video generation request that adds synchronized sound effects to video using Mirelo Studio.
    /// </summary>
    public sealed partial class GenerateVideoWithAudioRequest
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
        /// Default Value: video_with_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for video-to-video with audio generation (Mirelo Studio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_generation_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoGenerationModelId { get; set; }

        /// <summary>
        /// The id of the video asset to add sound effects to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// Optional prompt to guide the audio generation for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoWithAudioRequest" /> class.
        /// </summary>
        /// <param name="videoGenerationModelId">
        /// ID of the model to use for video-to-video with audio generation (Mirelo Studio).
        /// </param>
        /// <param name="videoId">
        /// The id of the video asset to add sound effects to.
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
        /// Default Value: video_with_audio
        /// </param>
        /// <param name="prompt">
        /// Optional prompt to guide the audio generation for the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoWithAudioRequest(
            global::System.Guid videoGenerationModelId,
            global::System.Guid videoId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            string? prompt)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.VideoGenerationModelId = videoGenerationModelId;
            this.VideoId = videoId;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoWithAudioRequest" /> class.
        /// </summary>
        public GenerateVideoWithAudioRequest()
        {
        }
    }
}