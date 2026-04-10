//HintName: G.Models.GenerateImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequest
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerateImageRequestTypeJsonConverter))]
        public global::G.GenerateImageRequestType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// The text prompt for image generation or image editing.
        /// </param>
        /// <param name="aiModelId">
        /// The model to use.
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
        public GenerateImageRequest(
            string textPrompt,
            global::System.Guid aiModelId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            global::G.GenerateImageRequestType? type,
            string? aspectRatio,
            string? resolution,
            global::System.Guid? startKeyframeId,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds,
            int? batchSize,
            bool? enhancePrompt)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }
    }
}