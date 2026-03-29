//HintName: G.Models.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice customization options. Read more here: https://docs.elevenlabs.io/speech-synthesis/voice-settings
    /// </summary>
    public sealed partial class UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig
    {
        /// <summary>
        /// How stable the voice is and the randomness of each new generation.<br/>
        /// If ElevenLabs V3 model is selected, must be one of these values: 0.0, 0.5, 1.0 (0.0 = Creative, 0.5 = Natural, 1.0 = Robust).<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The similarity slider dictates how closely the AI should adhere to the original voice when attempting to replicate it.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// The speed of the voice.<br/>
        /// The value is relative to 1. Valid range is 0.7 to 1.2.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::Newtonsoft.Json.JsonProperty("rate")]
        public string? Rate { get; set; }

        /// <summary>
        /// Determines the style exaggeration of the voice.<br/>
        /// This setting attempts to amplify the style of the original speaker.<br/>
        /// It does consume additional computational resources and might increase latency if set to anything other than 0.<br/>
        /// Valid range is 0 to 1.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public string? Style { get; set; }

        /// <summary>
        /// boosts the similarity to the original speaker.<br/>
        /// Using this setting requires a slightly higher computational load, which in turn increases latency.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("use_speaker_boost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Controls language text normalization. This helps with proper pronunciation of text in some supported languages.<br/>
        /// WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("apply_language_text_normalization")]
        public bool? ApplyLanguageTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig" /> class.
        /// </summary>
        /// <param name="stability">
        /// How stable the voice is and the randomness of each new generation.<br/>
        /// If ElevenLabs V3 model is selected, must be one of these values: 0.0, 0.5, 1.0 (0.0 = Creative, 0.5 = Natural, 1.0 = Robust).<br/>
        /// Example: 0
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity slider dictates how closely the AI should adhere to the original voice when attempting to replicate it.<br/>
        /// Example: 0
        /// </param>
        /// <param name="rate">
        /// The speed of the voice.<br/>
        /// The value is relative to 1. Valid range is 0.7 to 1.2.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="style">
        /// Determines the style exaggeration of the voice.<br/>
        /// This setting attempts to amplify the style of the original speaker.<br/>
        /// It does consume additional computational resources and might increase latency if set to anything other than 0.<br/>
        /// Valid range is 0 to 1.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="useSpeakerBoost">
        /// boosts the similarity to the original speaker.<br/>
        /// Using this setting requires a slightly higher computational load, which in turn increases latency.<br/>
        /// Example: true
        /// </param>
        /// <param name="applyLanguageTextNormalization">
        /// Controls language text normalization. This helps with proper pronunciation of text in some supported languages.<br/>
        /// WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Example: true
        /// </param>
        public UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig(
            double? stability,
            double? similarityBoost,
            string? rate,
            string? style,
            bool? useSpeakerBoost,
            bool? applyLanguageTextNormalization)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Rate = rate;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.ApplyLanguageTextNormalization = applyLanguageTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig" /> class.
        /// </summary>
        public UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig()
        {
        }
    }
}