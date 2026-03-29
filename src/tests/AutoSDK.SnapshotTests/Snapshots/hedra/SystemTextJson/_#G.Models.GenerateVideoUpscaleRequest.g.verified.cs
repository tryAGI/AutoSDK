//HintName: G.Models.GenerateVideoUpscaleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateVideoUpscaleRequest
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
        /// Default Value: video_upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model to use for upscaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AiModelId { get; set; }

        /// <summary>
        /// The id of the Video asset to upscale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// Computed scale factor derived from target_resolution and source video dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// Target output resolution. Must be one of: 1080p, 2K, 4K.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_resolution")]
        public string? TargetResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoUpscaleRequest" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The model to use for upscaling.
        /// </param>
        /// <param name="videoId">
        /// The id of the Video asset to upscale.
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
        /// Default Value: video_upscale
        /// </param>
        /// <param name="upscaleFactor">
        /// Computed scale factor derived from target_resolution and source video dimensions.
        /// </param>
        /// <param name="targetResolution">
        /// Target output resolution. Must be one of: 1080p, 2K, 4K.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoUpscaleRequest(
            global::System.Guid aiModelId,
            global::System.Guid videoId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            double? upscaleFactor,
            string? targetResolution)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.VideoId = videoId;
            this.UpscaleFactor = upscaleFactor;
            this.TargetResolution = targetResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoUpscaleRequest" /> class.
        /// </summary>
        public GenerateVideoUpscaleRequest()
        {
        }
    }
}