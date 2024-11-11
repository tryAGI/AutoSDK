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
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Audio { get; set; } = default!;

        /// <summary>
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audioname { get; set; } = default!;

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_settings")]
        public string? VoiceSettings { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        public BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost(
            byte[] audio,
            string audioname,
            string? modelId,
            string? voiceSettings,
            int? seed)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.ModelId = modelId;
            this.VoiceSettings = voiceSettings;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost" /> class.
        /// </summary>
        public BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost()
        {
        }
    }
}