//HintName: G.Models.VoiceSamplePreviewResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSamplePreviewResponseModel
    {
        /// <summary>
        /// The base64 encoded audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base_64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SampleId { get; set; } = default!;

        /// <summary>
        /// The media type of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MediaType { get; set; } = default!;

        /// <summary>
        /// The duration of the audio in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSamplePreviewResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// The base64 encoded audio.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice.
        /// </param>
        /// <param name="sampleId">
        /// The ID of the sample.
        /// </param>
        /// <param name="mediaType">
        /// The media type of the audio.
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the audio in seconds.
        /// </param>
        public VoiceSamplePreviewResponseModel(
            string audioBase64,
            string voiceId,
            string sampleId,
            string mediaType,
            double? durationSecs)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSamplePreviewResponseModel" /> class.
        /// </summary>
        public VoiceSamplePreviewResponseModel()
        {
        }
    }
}