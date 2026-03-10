//HintName: G.Models.BodySoundGenerationV1SoundGenerationPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySoundGenerationV1SoundGenerationPost
    {
        /// <summary>
        /// The text that will get converted into a sound effect.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Whether to create a sound effect that loops smoothly. Only available for the 'eleven_text_to_sound_v2 model'.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// The duration of the sound which will be generated in seconds. Must be at least 0.5 and at most 30. If set to None we will guess the optimal duration using the prompt. Defaults to None.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// A higher prompt influence makes your generation follow the prompt more closely while also making generations less variable. Must be a value between 0 and 1. Defaults to 0.3.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_influence")]
        public double? PromptInfluence { get; set; }

        /// <summary>
        /// The model ID to use for the sound generation.<br/>
        /// Default Value: eleven_text_to_sound_v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySoundGenerationV1SoundGenerationPost" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that will get converted into a sound effect.
        /// </param>
        /// <param name="loop">
        /// Whether to create a sound effect that loops smoothly. Only available for the 'eleven_text_to_sound_v2 model'.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="durationSeconds">
        /// The duration of the sound which will be generated in seconds. Must be at least 0.5 and at most 30. If set to None we will guess the optimal duration using the prompt. Defaults to None.
        /// </param>
        /// <param name="promptInfluence">
        /// A higher prompt influence makes your generation follow the prompt more closely while also making generations less variable. Must be a value between 0 and 1. Defaults to 0.3.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="modelId">
        /// The model ID to use for the sound generation.<br/>
        /// Default Value: eleven_text_to_sound_v2
        /// </param>
        public BodySoundGenerationV1SoundGenerationPost(
            string text,
            bool? loop,
            double? durationSeconds,
            double? promptInfluence,
            string? modelId)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Loop = loop;
            this.DurationSeconds = durationSeconds;
            this.PromptInfluence = promptInfluence;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySoundGenerationV1SoundGenerationPost" /> class.
        /// </summary>
        public BodySoundGenerationV1SoundGenerationPost()
        {
        }
    }
}