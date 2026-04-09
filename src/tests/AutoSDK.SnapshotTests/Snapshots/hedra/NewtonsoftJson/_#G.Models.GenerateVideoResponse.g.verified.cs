//HintName: G.Models.GenerateVideoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateVideoResponse
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
        /// Default Value: video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The id of the Image asset to use as the start keyframe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_keyframe_id")]
        public global::System.Guid? StartKeyframeId { get; set; }

        /// <summary>
        /// The URL of the image to use as the start keyframe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_keyframe_url")]
        public string? StartKeyframeUrl { get; set; }

        /// <summary>
        /// The id of the Image asset to use as the end keyframe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_keyframe_id")]
        public global::System.Guid? EndKeyframeId { get; set; }

        /// <summary>
        /// The URL of the image to use as the end keyframe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_keyframe_url")]
        public string? EndKeyframeUrl { get; set; }

        /// <summary>
        /// The id of the Audio asset to use, or a list of ids for multi-speaker generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_id")]
        public global::G.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>? AudioId { get; set; }

        /// <summary>
        /// Optional TTS parameters for server-side audio generation. If provided (and audio_id is not), audio will be generated from these params before video generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_generation")]
        public global::G.GenerateTextToSpeechRequest? AudioGeneration { get; set; }

        /// <summary>
        /// Audio start offset in milliseconds. Negative values prepend silence (e.g., -1000 adds 1s silence before audio). Positive values crop from the beginning of the source audio (e.g., 2000 skips the first 2s). Use with generated_video_inputs.duration_ms to control total output length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// The id(s) of the audio(s) to reference in the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_audio_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceAudioIds { get; set; }

        /// <summary>
        /// The id(s) of the image(s) to reference in the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_image_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageIds { get; set; }

        /// <summary>
        /// The id(s) of the video(s) to reference in the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_video_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceVideoIds { get; set; }

        /// <summary>
        /// The id of the Video asset to use as input. For V2V (motion control) models this is the driving video; for Google Veo models this triggers video extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id")]
        public global::System.Guid? VideoId { get; set; }

        /// <summary>
        /// Inputs for generating the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_video_inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeneratedVideoInputs GeneratedVideoInputs { get; set; } = default!;

        /// <summary>
        /// Number of video variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// The id of the generation created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The id of the video asset resulting from the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AssetId { get; set; } = default!;

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
        /// Unique identifier linking all generations in a batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_generation_id")]
        public string? BatchGenerationId { get; set; }

        /// <summary>
        /// All generation results in the batch. Always populated (even for batch_size=1). The main response fields (id, asset_id, etc.) reflect the first successful generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_results")]
        public global::System.Collections.Generic.IList<global::G.BatchVideoResultItem>? BatchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoResponse" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// ID of the model to use for the generation.
        /// </param>
        /// <param name="generatedVideoInputs">
        /// Inputs for generating the video.
        /// </param>
        /// <param name="id">
        /// The id of the generation created.
        /// </param>
        /// <param name="assetId">
        /// The id of the video asset resulting from the generation.
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
        /// Default Value: video
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the Image asset to use as the start keyframe.
        /// </param>
        /// <param name="startKeyframeUrl">
        /// The URL of the image to use as the start keyframe.
        /// </param>
        /// <param name="endKeyframeId">
        /// The id of the Image asset to use as the end keyframe.
        /// </param>
        /// <param name="endKeyframeUrl">
        /// The URL of the image to use as the end keyframe.
        /// </param>
        /// <param name="audioId">
        /// The id of the Audio asset to use, or a list of ids for multi-speaker generation.
        /// </param>
        /// <param name="audioGeneration">
        /// Optional TTS parameters for server-side audio generation. If provided (and audio_id is not), audio will be generated from these params before video generation.
        /// </param>
        /// <param name="audioStartMs">
        /// Audio start offset in milliseconds. Negative values prepend silence (e.g., -1000 adds 1s silence before audio). Positive values crop from the beginning of the source audio (e.g., 2000 skips the first 2s). Use with generated_video_inputs.duration_ms to control total output length.
        /// </param>
        /// <param name="referenceAudioIds">
        /// The id(s) of the audio(s) to reference in the generation.
        /// </param>
        /// <param name="referenceImageIds">
        /// The id(s) of the image(s) to reference in the generation.
        /// </param>
        /// <param name="referenceVideoIds">
        /// The id(s) of the video(s) to reference in the generation.
        /// </param>
        /// <param name="videoId">
        /// The id of the Video asset to use as input. For V2V (motion control) models this is the driving video; for Google Veo models this triggers video extension.
        /// </param>
        /// <param name="batchSize">
        /// Number of video variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="etaSec">
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </param>
        /// <param name="batchGenerationId">
        /// Unique identifier linking all generations in a batch.
        /// </param>
        /// <param name="batchResults">
        /// All generation results in the batch. Always populated (even for batch_size=1). The main response fields (id, asset_id, etc.) reflect the first successful generation.
        /// </param>
        public GenerateVideoResponse(
            global::System.Guid aiModelId,
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
            global::System.Guid? startKeyframeId,
            string? startKeyframeUrl,
            global::System.Guid? endKeyframeId,
            string? endKeyframeUrl,
            global::G.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>? audioId,
            global::G.GenerateTextToSpeechRequest? audioGeneration,
            int? audioStartMs,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceAudioIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceVideoIds,
            global::System.Guid? videoId,
            int? batchSize,
            int? etaSec,
            string? batchGenerationId,
            global::System.Collections.Generic.IList<global::G.BatchVideoResultItem>? batchResults)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.StartKeyframeId = startKeyframeId;
            this.StartKeyframeUrl = startKeyframeUrl;
            this.EndKeyframeId = endKeyframeId;
            this.EndKeyframeUrl = endKeyframeUrl;
            this.AudioId = audioId;
            this.AudioGeneration = audioGeneration;
            this.AudioStartMs = audioStartMs;
            this.ReferenceAudioIds = referenceAudioIds;
            this.ReferenceImageIds = referenceImageIds;
            this.ReferenceVideoIds = referenceVideoIds;
            this.VideoId = videoId;
            this.GeneratedVideoInputs = generatedVideoInputs ?? throw new global::System.ArgumentNullException(nameof(generatedVideoInputs));
            this.BatchSize = batchSize;
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
            this.BatchGenerationId = batchGenerationId;
            this.BatchResults = batchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoResponse" /> class.
        /// </summary>
        public GenerateVideoResponse()
        {
        }
    }
}