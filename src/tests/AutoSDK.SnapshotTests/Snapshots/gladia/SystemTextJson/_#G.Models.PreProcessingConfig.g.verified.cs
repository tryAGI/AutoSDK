//HintName: G.Models.PreProcessingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreProcessingConfig
    {
        /// <summary>
        /// If true, apply pre-processing to the audio stream to enhance the quality.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_enhancer")]
        public bool? AudioEnhancer { get; set; }

        /// <summary>
        /// Sensitivity configuration for Speech Threshold. A value close to 1 will apply stricter thresholds, making it less likely to detect background sounds as speech.<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public double? SpeechThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreProcessingConfig" /> class.
        /// </summary>
        /// <param name="audioEnhancer">
        /// If true, apply pre-processing to the audio stream to enhance the quality.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speechThreshold">
        /// Sensitivity configuration for Speech Threshold. A value close to 1 will apply stricter thresholds, making it less likely to detect background sounds as speech.<br/>
        /// Default Value: 0.6F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreProcessingConfig(
            bool? audioEnhancer,
            double? speechThreshold)
        {
            this.AudioEnhancer = audioEnhancer;
            this.SpeechThreshold = speechThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreProcessingConfig" /> class.
        /// </summary>
        public PreProcessingConfig()
        {
        }
    }
}