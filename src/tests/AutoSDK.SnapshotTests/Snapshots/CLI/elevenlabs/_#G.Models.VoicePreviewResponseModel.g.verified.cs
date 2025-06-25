//HintName: G.Models.VoicePreviewResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePreviewResponseModel
    {
        /// <summary>
        /// The base64 encoded audio of the preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// The ID of the generated voice. Use it to create a voice from the preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedVoiceId { get; set; }

        /// <summary>
        /// The media type of the preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// The duration of the preview in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// The base64 encoded audio of the preview.
        /// </param>
        /// <param name="generatedVoiceId">
        /// The ID of the generated voice. Use it to create a voice from the preview.
        /// </param>
        /// <param name="mediaType">
        /// The media type of the preview.
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the preview in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicePreviewResponseModel(
            string audioBase64,
            string generatedVoiceId,
            string mediaType,
            double durationSecs)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.GeneratedVoiceId = generatedVoiceId ?? throw new global::System.ArgumentNullException(nameof(generatedVoiceId));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewResponseModel" /> class.
        /// </summary>
        public VoicePreviewResponseModel()
        {
        }
    }
}