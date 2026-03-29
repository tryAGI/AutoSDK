//HintName: G.Models.GenerateImageUpscaleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageUpscaleRequest
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
        /// Default Value: image_upscale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model to use for upscaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The id of the Image asset to use as the basis for upscaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ImageId { get; set; } = default!;

        /// <summary>
        /// Optional upscale factor to pass to the model (e.g. 2.0 for 2x).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageUpscaleRequest" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The model to use for upscaling.
        /// </param>
        /// <param name="imageId">
        /// The id of the Image asset to use as the basis for upscaling.
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
        /// Default Value: image_upscale
        /// </param>
        /// <param name="upscaleFactor">
        /// Optional upscale factor to pass to the model (e.g. 2.0 for 2x).
        /// </param>
        public GenerateImageUpscaleRequest(
            global::System.Guid aiModelId,
            global::System.Guid imageId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            double? upscaleFactor)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.ImageId = imageId;
            this.UpscaleFactor = upscaleFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageUpscaleRequest" /> class.
        /// </summary>
        public GenerateImageUpscaleRequest()
        {
        }
    }
}