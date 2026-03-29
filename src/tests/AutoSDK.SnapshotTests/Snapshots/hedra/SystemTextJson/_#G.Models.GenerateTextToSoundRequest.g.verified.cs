//HintName: G.Models.GenerateTextToSoundRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextToSoundRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional agent thread ID to associate this generation with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_thread_id")]
        public global::System.Guid? AgentThreadId { get; set; }

        /// <summary>
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GenerationIds { get; set; }

        /// <summary>
        /// Default Value: text_to_sound
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the model to use for sound effect generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AiModelId { get; set; }

        /// <summary>
        /// The text description of the sound effect to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The duration of the sound effect in seconds (0.5-30). If not specified, duration is automatically determined from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Controls how strictly the model follows the prompt (0-1). Higher values mean more literal interpretation. Defaults to 0.3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_influence")]
        public double? PromptInfluence { get; set; }

        /// <summary>
        /// Whether to create a sound effect that loops smoothly. Only available for the eleven_text_to_sound_v2 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate (e.g., mp3_22050_32, mp3_44100_128, pcm_44100). If not specified, defaults to mp3_44100_128.<br/>
        /// Default Value: mp3_44100_128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToSoundRequest" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// The id of the model to use for sound effect generation.
        /// </param>
        /// <param name="text">
        /// The text description of the sound effect to generate.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTextToSoundRequest(
            global::System.Guid aiModelId,
            string text,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            double? durationSeconds,
            double? promptInfluence,
            bool? loop,
            string? outputFormat)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextToSoundRequest" /> class.
        /// </summary>
        public GenerateTextToSoundRequest()
        {
        }
    }
}