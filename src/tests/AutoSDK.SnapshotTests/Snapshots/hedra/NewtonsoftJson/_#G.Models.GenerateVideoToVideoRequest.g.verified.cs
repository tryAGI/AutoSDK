//HintName: G.Models.GenerateVideoToVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Video-to-video edit request for Kling O1 Edit model.<br/>
    /// Transforms videos using natural language while preserving motion.
    /// </summary>
    public sealed partial class GenerateVideoToVideoRequest
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
        /// Default Value: video_to_video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the model to use for video-to-video generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The id of the video asset to transform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VideoId { get; set; } = default!;

        /// <summary>
        /// Natural language transformation instructions. Use @Element1, @Image1 syntax to reference elements and images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Optional ids of reference image assets for style transfer. Reference as @Image1, @Image2, etc. in prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_image_asset_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageAssetIds { get; set; }

        /// <summary>
        /// Optional elements for character tracking. Reference as @Element1, @Element2, etc. in prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elements")]
        public global::System.Collections.Generic.IList<global::G.KlingEditElement>? Elements { get; set; }

        /// <summary>
        /// Whether to preserve the original audio from the input video. Automatically disabled when generate_audio is enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep_audio")]
        public bool? KeepAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoToVideoRequest" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The id of the model to use for video-to-video generation.
        /// </param>
        /// <param name="videoId">
        /// The id of the video asset to transform.
        /// </param>
        /// <param name="prompt">
        /// Natural language transformation instructions. Use @Element1, @Image1 syntax to reference elements and images.
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
        /// Default Value: video_to_video
        /// </param>
        /// <param name="referenceImageAssetIds">
        /// Optional ids of reference image assets for style transfer. Reference as @Image1, @Image2, etc. in prompt.
        /// </param>
        /// <param name="elements">
        /// Optional elements for character tracking. Reference as @Element1, @Element2, etc. in prompt.
        /// </param>
        /// <param name="keepAudio">
        /// Whether to preserve the original audio from the input video. Automatically disabled when generate_audio is enabled.<br/>
        /// Default Value: true
        /// </param>
        public GenerateVideoToVideoRequest(
            global::System.Guid aiModelId,
            global::System.Guid videoId,
            string prompt,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageAssetIds,
            global::System.Collections.Generic.IList<global::G.KlingEditElement>? elements,
            bool? keepAudio)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.VideoId = videoId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImageAssetIds = referenceImageAssetIds;
            this.Elements = elements;
            this.KeepAudio = keepAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoToVideoRequest()
        {
        }
    }
}