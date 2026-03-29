//HintName: G.Models.GenerateTextToSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextToSpeechRequest
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
        /// Default Value: text_to_speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the Voice to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VoiceId { get; set; } = default!;

        /// <summary>
        /// The id of the model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public global::System.Guid? ModelId { get; set; }

        /// <summary>
        /// The text to convert to speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Stability should be between 0-1, where 0 is the most stable and 1 is the most unstable. This varies the consistency between your outputs.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Speed should be between 0.7 and 1.2, where 0.7 is the slowest and 1.2 is the fastest. This varies the speed of the generated speech.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Language for TTS. See SupportedLanguage enum for valid values. Defaults to 'auto'.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The id of the Voice to use.
        /// </param>
        /// <param name="text">
        /// The text to convert to speech.
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
        /// Default Value: text_to_speech
        /// </param>
        /// <param name="modelId">
        /// The id of the model to use.
        /// </param>
        /// <param name="stability">
        /// Stability should be between 0-1, where 0 is the most stable and 1 is the most unstable. This varies the consistency between your outputs.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="speed">
        /// Speed should be between 0.7 and 1.2, where 0.7 is the slowest and 1.2 is the fastest. This varies the speed of the generated speech.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="language">
        /// Language for TTS. See SupportedLanguage enum for valid values. Defaults to 'auto'.<br/>
        /// Default Value: auto
        /// </param>
        public GenerateTextToSpeechRequest(
            global::System.Guid voiceId,
            string text,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            global::System.Guid? modelId,
            double? stability,
            double? speed,
            global::G.SupportedLanguage? language)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.VoiceId = voiceId;
            this.ModelId = modelId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Stability = stability;
            this.Speed = speed;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToSpeechRequest" /> class.
        /// </summary>
        public GenerateTextToSpeechRequest()
        {
        }
    }
}