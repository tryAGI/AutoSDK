//HintName: G.Models.SampleResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"file_name":"sample.mp3","hash":"1234567890","mime_type":"audio/mpeg","sample_id":"DCwhRBWXzGAHq8TQ4Fs18","size_bytes":1000000}
    /// </summary>
    public sealed partial class SampleResponseModel
    {
        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// The name of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The MIME type of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The size of the sample file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// The hash of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_isolated_audio")]
        public bool? HasIsolatedAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_isolated_audio_preview")]
        public bool? HasIsolatedAudioPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_separation")]
        public global::G.SpeakerSeparationResponseModel? SpeakerSeparation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_start")]
        public int? TrimStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_end")]
        public int? TrimEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="trimStart"></param>
        /// <param name="trimEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            global::G.SpeakerSeparationResponseModel? speakerSeparation,
            int? trimStart,
            int? trimEnd)
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
            this.TrimStart = trimStart;
            this.TrimEnd = trimEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        public SampleResponseModel()
        {
        }
    }
}