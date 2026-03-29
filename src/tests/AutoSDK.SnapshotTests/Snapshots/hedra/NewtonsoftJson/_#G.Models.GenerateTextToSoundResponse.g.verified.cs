//HintName: G.Models.GenerateTextToSoundResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextToSoundResponse
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
        /// Default Value: text_to_sound
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the model to use for sound effect generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AiModelId { get; set; } = default!;

        /// <summary>
        /// The text description of the sound effect to generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The duration of the sound effect in seconds (0.5-30). If not specified, duration is automatically determined from the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Controls how strictly the model follows the prompt (0-1). Higher values mean more literal interpretation. Defaults to 0.3.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_influence")]
        public double? PromptInfluence { get; set; }

        /// <summary>
        /// Whether to create a sound effect that loops smoothly. Only available for the eleven_text_to_sound_v2 model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate (e.g., mp3_22050_32, mp3_44100_128, pcm_44100). If not specified, defaults to mp3_44100_128.<br/>
        /// Default Value: mp3_44100_128
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// The id of the generation created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The id of the audio asset resulting from the generation.
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
        /// Initializes a new instance of the <see cref="GenerateTextToSoundResponse" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The id of the model to use for sound effect generation.
        /// </param>
        /// <param name="text">
        /// The text description of the sound effect to generate.
        /// </param>
        /// <param name="id">
        /// The id of the generation created.
        /// </param>
        /// <param name="assetId">
        /// The id of the audio asset resulting from the generation.
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
        /// Default Value: text_to_sound
        /// </param>
        /// <param name="durationSeconds">
        /// The duration of the sound effect in seconds (0.5-30). If not specified, duration is automatically determined from the prompt.
        /// </param>
        /// <param name="promptInfluence">
        /// Controls how strictly the model follows the prompt (0-1). Higher values mean more literal interpretation. Defaults to 0.3.
        /// </param>
        /// <param name="loop">
        /// Whether to create a sound effect that loops smoothly. Only available for the eleven_text_to_sound_v2 model.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate (e.g., mp3_22050_32, mp3_44100_128, pcm_44100). If not specified, defaults to mp3_44100_128.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="etaSec">
        /// Estimated time until completion in seconds. May be None if no historical data available.
        /// </param>
        public GenerateTextToSoundResponse(
            global::System.Guid aiModelId,
            string text,
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
            double? durationSeconds,
            double? promptInfluence,
            bool? loop,
            string? outputFormat,
            int? etaSec)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DurationSeconds = durationSeconds;
            this.PromptInfluence = promptInfluence;
            this.Loop = loop;
            this.OutputFormat = outputFormat;
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToSoundResponse" /> class.
        /// </summary>
        public GenerateTextToSoundResponse()
        {
        }
    }
}