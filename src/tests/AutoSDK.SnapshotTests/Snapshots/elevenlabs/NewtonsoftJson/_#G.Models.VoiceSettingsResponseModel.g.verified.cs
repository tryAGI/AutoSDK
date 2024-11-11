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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability", Required = global::Newtonsoft.Json.Required.Always)]
        public double Stability { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost", Required = global::Newtonsoft.Json.Required.Always)]
        public double SimilarityBoost { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_speaker_boost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="stability"></param>
        /// <param name="similarityBoost"></param>
        /// <param name="style">
        /// Default Value: 0
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Default Value: true
        /// </param>
        public VoiceSettingsResponseModel(
            double stability,
            double similarityBoost,
            double? style,
            bool? useSpeakerBoost)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsResponseModel" /> class.
        /// </summary>
        public VoiceSettingsResponseModel()
        {
        }
    }
}