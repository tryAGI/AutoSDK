//HintName: G.Models.GeneratedAudioInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedAudioInputs
    {
        /// <summary>
        /// Prompt for audio generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string TextPrompt { get; set; } = default!;

        /// <summary>
        /// The id of the model used for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// The display name of the voice used for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name")]
        public string? VoiceName { get; set; }

        /// <summary>
        /// The id of the voice used for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public global::System.Guid? VoiceId { get; set; }

        /// <summary>
        /// Stability setting used for generation (0-1).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Speed setting used for generation (0.7-1.2).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Language used for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAudioInputs" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Prompt for audio generation.
        /// </param>
        /// <param name="aiModelId">
        /// The id of the model used for generation.
        /// </param>
        /// <param name="voiceName">
        /// The display name of the voice used for generation.
        /// </param>
        /// <param name="voiceId">
        /// The id of the voice used for generation.
        /// </param>
        /// <param name="stability">
        /// Stability setting used for generation (0-1).
        /// </param>
        /// <param name="speed">
        /// Speed setting used for generation (0.7-1.2).
        /// </param>
        /// <param name="language">
        /// Language used for generation.
        /// </param>
        public GeneratedAudioInputs(
            string textPrompt,
            global::System.Guid? aiModelId,
            string? voiceName,
            global::System.Guid? voiceId,
            double? stability,
            double? speed,
            string? language)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.AiModelId = aiModelId;
            this.VoiceName = voiceName;
            this.VoiceId = voiceId;
            this.Stability = stability;
            this.Speed = speed;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAudioInputs" /> class.
        /// </summary>
        public GeneratedAudioInputs()
        {
        }
    }
}