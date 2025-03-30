//HintName: G.Models.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost
    {
        /// <summary>
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice settings overriding stored settings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public string? VoiceSettings { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// If set, will remove the background noise from your audio input using our audio isolation model. Only applies to Voice Changer.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost" /> class.
        /// </summary>
        /// <param name="audio">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="audioname">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored settings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set, will remove the background noise from your audio input using our audio isolation model. Only applies to Voice Changer.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost(
            byte[] audio,
            string audioname,
            string? modelId,
            string? voiceSettings,
            int? seed,
            bool? removeBackgroundNoise)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.ModelId = modelId;
            this.VoiceSettings = voiceSettings;
            this.Seed = seed;
            this.RemoveBackgroundNoise = removeBackgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost" /> class.
        /// </summary>
        public BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost()
        {
        }
    }
}