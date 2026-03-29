//HintName: G.Models.GenerateSpeechToSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSpeechToSpeechRequest
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
        /// Default Value: speech_to_speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the audio asset requiring sound isolation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AudioId { get; set; } = default!;

        /// <summary>
        /// The id of the model to use for audio isolation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The id of the Voice to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechToSpeechRequest" /> class.
        /// </summary>
        /// <param name="audioId">
        /// The id of the audio asset requiring sound isolation.
        /// </param>
        /// <param name="aiModelId">
        /// The id of the model to use for audio isolation.
        /// </param>
        /// <param name="voiceId">
        /// The id of the Voice to use.
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
        /// Default Value: speech_to_speech
        /// </param>
        public GenerateSpeechToSpeechRequest(
            global::System.Guid audioId,
            global::System.Guid aiModelId,
            global::System.Guid voiceId,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AudioId = audioId;
            this.AiModelId = aiModelId;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechToSpeechRequest" /> class.
        /// </summary>
        public GenerateSpeechToSpeechRequest()
        {
        }
    }
}