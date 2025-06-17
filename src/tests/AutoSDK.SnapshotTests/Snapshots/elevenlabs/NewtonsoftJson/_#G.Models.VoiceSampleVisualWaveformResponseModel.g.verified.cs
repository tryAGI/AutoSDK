//HintName: G.Models.VoiceSampleVisualWaveformResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSampleVisualWaveformResponseModel
    {
        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SampleId { get; set; } = default!;

        /// <summary>
        /// The visual waveform of the sample, represented as a list of floats.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visual_waveform", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> VisualWaveform { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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