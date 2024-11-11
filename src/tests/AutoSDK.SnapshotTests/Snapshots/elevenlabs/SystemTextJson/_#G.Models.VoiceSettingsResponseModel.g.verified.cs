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
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Stability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SimilarityBoost { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_speaker_boost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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