//HintName: G.Models.VoiceSettingsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSettingsResponseModel
    {
        /// <summary>
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Determines how closely the AI should adhere to the original voice when attempting to replicate it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Determines the style exaggeration of the voice. This setting attempts to amplify the style of the original speaker. It does consume additional computational resources and might increase latency if set to anything other than 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public double? Style { get; set; }

        /// <summary>
        /// This setting boosts the similarity to the original speaker. Using this setting requires a slightly higher computational load, which in turn increases latency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_speaker_boost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Controls the speed of the generated speech. Values range from 0.7 to 1.2, with 1.0 being the default speed. Lower values create slower, more deliberate speech while higher values produce faster-paced speech. Extreme values can impact the quality of the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="stability">
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.
        /// </param>
        /// <param name="similarityBoost">
        /// Determines how closely the AI should adhere to the original voice when attempting to replicate it.
        /// </param>
        /// <param name="style">
        /// Determines the style exaggeration of the voice. This setting attempts to amplify the style of the original speaker. It does consume additional computational resources and might increase latency if set to anything other than 0.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// This setting boosts the similarity to the original speaker. Using this setting requires a slightly higher computational load, which in turn increases latency.
        /// </param>
        /// <param name="speed">
        /// Controls the speed of the generated speech. Values range from 0.7 to 1.2, with 1.0 being the default speed. Lower values create slower, more deliberate speech while higher values produce faster-paced speech. Extreme values can impact the quality of the generated speech.
        /// </param>
        public VoiceSettingsResponseModel(
            double? stability,
            double? similarityBoost,
            double? style,
            bool? useSpeakerBoost,
            double? speed)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsResponseModel" /> class.
        /// </summary>
        public VoiceSettingsResponseModel()
        {
        }
    }
}