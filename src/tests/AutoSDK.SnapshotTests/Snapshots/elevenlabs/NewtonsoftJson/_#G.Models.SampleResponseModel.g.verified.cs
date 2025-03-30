//HintName: G.Models.SampleResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleResponseModel
    {
        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SampleId { get; set; } = default!;

        /// <summary>
        /// The name of the sample file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// The MIME type of the sample file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// The size of the sample file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeBytes { get; set; } = default!;

        /// <summary>
        /// The hash of the sample file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hash { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_isolated_audio")]
        public bool? HasIsolatedAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_isolated_audio_preview")]
        public bool? HasIsolatedAudioPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_separation")]
        public global::G.SpeakerSeparationResponseModel? SpeakerSeparation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        /// <param name="sampleId">
        /// The ID of the sample.
        /// </param>
        /// <param name="fileName">
        /// The name of the sample file.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the sample file.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the sample file in bytes.
        /// </param>
        /// <param name="hash">
        /// The hash of the sample file.
        /// </param>
        /// <param name="durationSecs"></param>
        /// <param name="removeBackgroundNoise"></param>
        /// <param name="hasIsolatedAudio"></param>
        /// <param name="hasIsolatedAudioPreview"></param>
        /// <param name="speakerSeparation"></param>
        public SampleResponseModel(
            string sampleId,
            string fileName,
            string mimeType,
            int sizeBytes,
            string hash,
            double? durationSecs,
            bool? removeBackgroundNoise,
            bool? hasIsolatedAudio,
            bool? hasIsolatedAudioPreview,
            global::G.SpeakerSeparationResponseModel? speakerSeparation)
        {
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.DurationSecs = durationSecs;
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.HasIsolatedAudio = hasIsolatedAudio;
            this.HasIsolatedAudioPreview = hasIsolatedAudioPreview;
            this.SpeakerSeparation = speakerSeparation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        public SampleResponseModel()
        {
        }
    }
}