//HintName: G.Models.UltravoxV1PlayHtVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a voice served by PlayHT.
    /// </summary>
    public sealed partial class UltravoxV1PlayHtVoice
    {
        /// <summary>
        /// The "user id" for the PlayHT API. This must be the user who owns the Play API key<br/>
        ///  associated with your Ultravox account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The ID of the voice in PlayHT. Typically an s3 location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The PlayHT model (aka "engine") to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0 and 5. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public float? Emotion { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceGuidance")]
        public float? VoiceGuidance { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleGuidance")]
        public float? StyleGuidance { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textGuidance")]
        public float? TextGuidance { get; set; }

        /// <summary>
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceConditioningSeconds")]
        public float? VoiceConditioningSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1PlayHtVoice" /> class.
        /// </summary>
        /// <param name="userId">
        /// The "user id" for the PlayHT API. This must be the user who owns the Play API key<br/>
        ///  associated with your Ultravox account.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice in PlayHT. Typically an s3 location.
        /// </param>
        /// <param name="model">
        /// The PlayHT model (aka "engine") to use.
        /// </param>
        /// <param name="speed">
        /// The speaking rate. Must be between 0 and 5. Defaults to 1.
        /// </param>
        /// <param name="quality">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="temperature">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="emotion">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="voiceGuidance">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="styleGuidance">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="textGuidance">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
        /// <param name="voiceConditioningSeconds">
        /// See https://docs.play.ht/reference/api-generate-tts-audio-stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1PlayHtVoice(
            string? userId,
            string? voiceId,
            string? model,
            float? speed,
            string? quality,
            float? temperature,
            float? emotion,
            float? voiceGuidance,
            float? styleGuidance,
            float? textGuidance,
            float? voiceConditioningSeconds)
        {
            this.UserId = userId;
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.Quality = quality;
            this.Temperature = temperature;
            this.Emotion = emotion;
            this.VoiceGuidance = voiceGuidance;
            this.StyleGuidance = styleGuidance;
            this.TextGuidance = textGuidance;
            this.VoiceConditioningSeconds = voiceConditioningSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1PlayHtVoice" /> class.
        /// </summary>
        public UltravoxV1PlayHtVoice()
        {
        }
    }
}