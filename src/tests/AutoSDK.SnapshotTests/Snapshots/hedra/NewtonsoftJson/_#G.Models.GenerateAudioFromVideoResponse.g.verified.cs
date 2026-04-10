//HintName: G.Models.GenerateAudioFromVideoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateAudioFromVideoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional agent thread ID to associate this generation with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_thread_id")]
        public global::System.Guid? AgentThreadId { get; set; }

        /// <summary>
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GenerationIds { get; set; }

        /// <summary>
        /// Default Value: audio_from_video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for video-to-audio generation (Mirelo Studio).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_generation_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AudioGenerationModelId { get; set; } = default!;

        /// <summary>
        /// The id of the video asset to generate audio from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VideoId { get; set; } = default!;

        /// <summary>
        /// Optional prompt to guide the audio generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The id of the generation created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The id of the audio asset resulting from the generation. Only present when generation is complete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id")]
        public global::System.Guid? AssetId { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Status of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerationStatusJsonConverter))]
        public global::G.GenerationStatus Status { get; set; } = default!;

        /// <summary>
        /// Current progress to completion. Between 0-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eta_sec")]
        public int? EtaSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAudioFromVideoResponse" /> class.
        /// </summary>
        /// <param name="audioGenerationModelId">
        /// ID of the model to use for video-to-audio generation (Mirelo Studio).
        /// </param>
        /// <param name="videoId">
        /// The id of the video asset to generate audio from.
        /// </param>
        /// <param name="id">
        /// The id of the generation created.
        /// </param>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="status">
        /// Status of the generation
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1
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
        /// <param name="assetId">
        /// The id of the audio asset resulting from the generation. Only present when generation is complete.
        /// </param>
        /// <param name="etaSec">
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </param>
        public GenerateAudioFromVideoResponse(
            global::System.Guid audioGenerationModelId,
            global::System.Guid videoId,
            global::System.Guid id,
            string createdAt,
            global::G.GenerationStatus status,
            double progress,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            string? prompt,
            global::System.Guid? assetId,
            int? etaSec)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AudioGenerationModelId = audioGenerationModelId;
            this.VideoId = videoId;
            this.Prompt = prompt;
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAudioFromVideoResponse" /> class.
        /// </summary>
        public GenerateAudioFromVideoResponse()
        {
        }
    }
}