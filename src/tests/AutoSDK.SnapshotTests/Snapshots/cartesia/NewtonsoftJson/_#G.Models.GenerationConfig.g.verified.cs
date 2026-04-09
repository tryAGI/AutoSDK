//HintName: G.Models.GenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
    /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
    /// </summary>
    public sealed partial class GenerationConfig
    {
        /// <summary>
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the original volume (default is 1.0x). Valid values are between [0.5, 2.0] inclusive.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Adjust the speed of the generated speech between 0.6x and 1.5x the original speed (default is 1.0x). Valid values are between [0.6, 1.5] inclusive.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The primary emotions are `neutral`, `calm`, `angry`, `content`, `sad`, `scared`. For more options, see [Prompting Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion#emotion-controls-beta).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmotionJsonConverter))]
        public global::G.Emotion? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        /// <param name="volume">
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the original volume (default is 1.0x). Valid values are between [0.5, 2.0] inclusive.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="speed">
        /// Adjust the speed of the generated speech between 0.6x and 1.5x the original speed (default is 1.0x). Valid values are between [0.6, 1.5] inclusive.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="emotion">
        /// The primary emotions are `neutral`, `calm`, `angry`, `content`, `sad`, `scared`. For more options, see [Prompting Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion#emotion-controls-beta).
        /// </param>
        public GenerationConfig(
            double? volume,
            double? speed,
            global::G.Emotion? emotion)
        {
            this.Volume = volume;
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        public GenerationConfig()
        {
        }
    }
}