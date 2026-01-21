//HintName: G.Models.VoiceSamplePreviewResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"audio_base_64":"audio_base_64","duration_secs":5,"media_type":"audio/mpeg","sample_id":"DCwhRBWXzGAHq8TQ4Fs18","voice_id":"DCwhRBWXzGAHq8TQ4Fs18"}
    /// </summary>
    public sealed partial class VoiceSamplePreviewResponseModel
    {
        /// <summary>
        /// The base64 encoded audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// The media type of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// The duration of the audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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