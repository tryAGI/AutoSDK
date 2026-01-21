//HintName: G.Models.VoiceSampleVisualWaveformResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"sample_id":"DCwhRBWXzGAHq8TQ4Fs18","visual_waveform":[0.1,0.2,0.3,0.4,0.5]}
    /// </summary>
    public sealed partial class VoiceSampleVisualWaveformResponseModel
    {
        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// The visual waveform of the sample, represented as a list of floats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visual_waveform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> VisualWaveform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSampleVisualWaveformResponseModel" /> class.
        /// </summary>
        /// <param name="sampleId">
        /// The ID of the sample.
        /// </param>
        /// <param name="visualWaveform">
        /// The visual waveform of the sample, represented as a list of floats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSampleVisualWaveformResponseModel(
            string sampleId,
            global::System.Collections.Generic.IList<double> visualWaveform)
        {
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.VisualWaveform = visualWaveform ?? throw new global::System.ArgumentNullException(nameof(visualWaveform));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSampleVisualWaveformResponseModel" /> class.
        /// </summary>
        public VoiceSampleVisualWaveformResponseModel()
        {
        }
    }
}