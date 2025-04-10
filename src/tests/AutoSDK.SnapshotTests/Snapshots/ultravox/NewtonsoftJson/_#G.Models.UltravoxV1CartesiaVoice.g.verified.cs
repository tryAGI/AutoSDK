//HintName: G.Models.UltravoxV1CartesiaVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a voice served by Cartesia.
    /// </summary>
    public sealed partial class UltravoxV1CartesiaVoice
    {
        /// <summary>
        /// The ID of the voice in Cartesia.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The Cartesia model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The speaking rate. Must be between -1 and 1. Defaults to 0.<br/>
        ///  See https://docs.cartesia.ai/api-reference/tts/tts#send.Generation%20Request.voice.Ttsrequest%20ID%20Specifier.__experimental_controls.speed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// See https://docs.cartesia.ai/api-reference/tts/tts#send.Generation%20Request.voice.Ttsrequest%20ID%20Specifier.__experimental_controls.emotion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in Cartesia.
        /// </param>
        /// <param name="model">
        /// The Cartesia model to use.
        /// </param>
        /// <param name="speed">
        /// The speaking rate. Must be between -1 and 1. Defaults to 0.<br/>
        ///  See https://docs.cartesia.ai/api-reference/tts/tts#send.Generation%20Request.voice.Ttsrequest%20ID%20Specifier.__experimental_controls.speed
        /// </param>
        /// <param name="emotion">
        /// See https://docs.cartesia.ai/api-reference/tts/tts#send.Generation%20Request.voice.Ttsrequest%20ID%20Specifier.__experimental_controls.emotion
        /// </param>
        public UltravoxV1CartesiaVoice(
            string? voiceId,
            string? model,
            float? speed,
            string? emotion)
        {
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoice" /> class.
        /// </summary>
        public UltravoxV1CartesiaVoice()
        {
        }
    }
}