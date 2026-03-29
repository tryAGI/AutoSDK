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
        /// Default Value: video_with_audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for video-to-video with audio generation (Mirelo Studio).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_generation_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VideoGenerationModelId { get; set; } = default!;

        /// <summary>
        /// The id of the video asset to add sound effects to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VideoId { get; set; } = default!;

        /// <summary>
        /// Optional prompt to guide the audio generation for the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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