//HintName: G.Models.GenerateImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageResponse
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
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GenerateImageResponseType? Type { get; set; }

        /// <summary>
        /// The text prompt for image generation or image editing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string TextPrompt { get; set; } = default!;

        /// <summary>
        /// The aspect ratio to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The resolution to use formatted like '540p', '1080p', '1440p (2K QHD)', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// The id of the Image asset to use as the start keyframe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_keyframe_id")]
        public global::System.Guid? StartKeyframeId { get; set; }

        /// <summary>
        /// The model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The id(s) of the image(s) to reference in the generation. This is only used for image-to-image generation and will supersede start_keyframe_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_image_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageIds { get; set; }

        /// <summary>
        /// Number of image variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// The id of the resulting image asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AssetId { get; set; } = default!;

        /// <summary>
        /// The id of the generation. Can be used to check status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Status of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
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
        public global::System.Collections.Generic.IList<global::G.BatchImageResultItem>? BatchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// The text prompt for image generation or image editing.
        /// </param>
        /// <param name="aiModelId">
        /// The model to use.
        /// </param>
        /// <param name="assetId">
        /// The id of the resulting image asset.
        /// </param>
        /// <param name="id">
        /// The id of the generation. Can be used to check status.
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
        /// Default Value: image
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use.
        /// </param>
        /// <param name="resolution">
        /// The resolution to use formatted like '540p', '1080p', '1440p (2K QHD)', etc.
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the Image asset to use as the start keyframe.
        /// </param>
        /// <param name="referenceImageIds">
        /// The id(s) of the image(s) to reference in the generation. This is only used for image-to-image generation and will supersede start_keyframe_id.
        /// </param>
        /// <param name="batchSize">
        /// Number of image variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enhancePrompt">
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
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
        public GenerateImageResponse(
            string textPrompt,
            global::System.Guid aiModelId,
            global::System.Guid assetId,
            global::System.Guid id,
            string createdAt,
            global::G.GenerationStatus status,
            double progress,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::G.GenerateImageResponseType? type,
            string? aspectRatio,
            string? resolution,
            global::System.Guid? startKeyframeId,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds,
            int? batchSize,
            bool? enhancePrompt,
            int? etaSec,
            string? batchGenerationId,
            global::System.Collections.Generic.IList<global::G.BatchImageResultItem>? batchResults)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.StartKeyframeId = startKeyframeId;
            this.AiModelId = aiModelId;
            this.ReferenceImageIds = referenceImageIds;
            this.BatchSize = batchSize;
            this.EnhancePrompt = enhancePrompt;
            this.AssetId = assetId;
            this.Id = id;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
            this.BatchGenerationId = batchGenerationId;
            this.BatchResults = batchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        public GenerateImageResponse()
        {
        }
    }
}