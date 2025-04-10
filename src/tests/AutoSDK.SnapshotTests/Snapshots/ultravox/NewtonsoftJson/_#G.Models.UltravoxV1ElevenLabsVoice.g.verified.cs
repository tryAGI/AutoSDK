//HintName: G.Models.UltravoxV1ElevenLabsVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a voice served by ElevenLabs.
    /// </summary>
    public sealed partial class UltravoxV1ElevenLabsVoice
    {
        /// <summary>
        /// The ID of the voice in ElevenLabs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The ElevenLabs model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0.7 and 1.2. Defaults to 1.<br/>
        ///  See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.speed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.use_speaker_boost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useSpeakerBoost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.style
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public float? Style { get; set; }

        /// <summary>
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.similarity_boost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarityBoost")]
        public float? SimilarityBoost { get; set; }

        /// <summary>
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.stability
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public float? Stability { get; set; }

        /// <summary>
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.pronunciation_dictionary_locators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionaries")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? PronunciationDictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ElevenLabsVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in ElevenLabs.
        /// </param>
        /// <param name="model">
        /// The ElevenLabs model to use.
        /// </param>
        /// <param name="speed">
        /// The speaking rate. Must be between 0.7 and 1.2. Defaults to 1.<br/>
        ///  See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.speed
        /// </param>
        /// <param name="useSpeakerBoost">
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.use_speaker_boost
        /// </param>
        /// <param name="style">
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.style
        /// </param>
        /// <param name="similarityBoost">
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.similarity_boost
        /// </param>
        /// <param name="stability">
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.voice_settings.stability
        /// </param>
        /// <param name="pronunciationDictionaries">
        /// See https://elevenlabs.io/docs/api-reference/text-to-speech/convert#request.body.pronunciation_dictionary_locators
        /// </param>
        public UltravoxV1ElevenLabsVoice(
            string? voiceId,
            string? model,
            float? speed,
            bool? useSpeakerBoost,
            float? style,
            float? similarityBoost,
            float? stability,
            global::System.Collections.Generic.IList<global::G.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? pronunciationDictionaries)
        {
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.Style = style;
            this.SimilarityBoost = similarityBoost;
            this.Stability = stability;
            this.PronunciationDictionaries = pronunciationDictionaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ElevenLabsVoice" /> class.
        /// </summary>
        public UltravoxV1ElevenLabsVoice()
        {
        }
    }
}