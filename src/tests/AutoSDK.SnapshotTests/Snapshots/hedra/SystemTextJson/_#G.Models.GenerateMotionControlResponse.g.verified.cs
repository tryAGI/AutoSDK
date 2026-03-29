//HintName: G.Models.GenerateMotionControlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for Motion Control generations.
    /// </summary>
    public sealed partial class GenerateMotionControlResponse
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
        /// Default Value: motion_control
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the Motion Control model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AiModelId { get; set; }

        /// <summary>
        /// The id of the video asset to use as motion reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// The id of the character image asset to animate with the motion from the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_keyframe_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid StartKeyframeId { get; set; }

        /// <summary>
        /// Video generation parameters including text_prompt and character_orientation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_video_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedVideoInputs GeneratedVideoInputs { get; set; }

        /// <summary>
        /// The id of the generation. Can be used to check status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The id of the output video asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssetId { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Status of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenerationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GenerationStatus Status { get; set; }

        /// <summary>
        /// Current progress to completion. Between 0-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eta_sec")]
        public int? EtaSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMotionControlResponse" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The id of the Motion Control model to use.
        /// </param>
        /// <param name="videoId">
        /// The id of the video asset to use as motion reference.
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the character image asset to animate with the motion from the video.
        /// </param>
        /// <param name="generatedVideoInputs">
        /// Video generation parameters including text_prompt and character_orientation.
        /// </param>
        /// <param name="id">
        /// The id of the generation. Can be used to check status.
        /// </param>
        /// <param name="assetId">
        /// The id of the output video asset.
        /// </param>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="status">
        /// Status of the generation.
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1.
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
        /// Default Value: motion_control
        /// </param>
        /// <param name="etaSec">
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateMotionControlResponse(
            global::System.Guid aiModelId,
            global::System.Guid videoId,
            global::System.Guid startKeyframeId,
            global::G.GeneratedVideoInputs generatedVideoInputs,
            global::System.Guid id,
            global::System.Guid assetId,
            string createdAt,
            global::G.GenerationStatus status,
            double progress,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            int? etaSec)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.VideoId = videoId;
            this.StartKeyframeId = startKeyframeId;
            this.GeneratedVideoInputs = generatedVideoInputs ?? throw new global::System.ArgumentNullException(nameof(generatedVideoInputs));
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMotionControlResponse" /> class.
        /// </summary>
        public GenerateMotionControlResponse()
        {
        }
    }
}