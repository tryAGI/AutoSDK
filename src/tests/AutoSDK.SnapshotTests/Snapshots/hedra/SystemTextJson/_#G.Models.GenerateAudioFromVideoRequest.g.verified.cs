//HintName: G.Models.GenerateAudioFromVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio generation request that extracts sound effects from video using Mirelo Studio.
    /// </summary>
    public sealed partial class GenerateAudioFromVideoRequest
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
        /// Default Value: audio_from_video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for video-to-audio generation (Mirelo Studio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_generation_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AudioGenerationModelId { get; set; }

        /// <summary>
        /// The id of the video asset to generate audio from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// Optional prompt to guide the audio generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAudioFromVideoRequest" /> class.
        /// </summary>
        /// <param name="audioGenerationModelId">
        /// ID of the model to use for video-to-audio generation (Mirelo Studio).
        /// </param>
        /// <param name="videoId">
        /// The id of the video asset to generate audio from.
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
        /// Default Value: audio_from_video
        /// </param>
        /// <param name="prompt">
        /// Optional prompt to guide the audio generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateAudioFromVideoRequest(
            global::System.Guid audioGenerationModelId,
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
            this.AudioGenerationModelId = audioGenerationModelId;
            this.VideoId = videoId;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAudioFromVideoRequest" /> class.
        /// </summary>
        public GenerateAudioFromVideoRequest()
        {
        }
    }
}