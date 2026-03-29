//HintName: G.Models.TtsLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts_engine")]
        public string? TtsEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_voice_id")]
        public string? ExternalVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts_model_name")]
        public string? TtsModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts_emotion_control")]
        public string? TtsEmotionControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_settings")]
        public global::G.VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLayer" /> class.
        /// </summary>
        /// <param name="ttsEngine"></param>
        /// <param name="apiKey"></param>
        /// <param name="externalVoiceId"></param>
        /// <param name="ttsModelName"></param>
        /// <param name="ttsEmotionControl"></param>
        /// <param name="voiceSettings"></param>
        public TtsLayer(
            string? ttsEngine,
            string? apiKey,
            string? externalVoiceId,
            string? ttsModelName,
            string? ttsEmotionControl,
            global::G.VoiceSettings? voiceSettings)
        {
            this.TtsEngine = ttsEngine;
            this.ApiKey = apiKey;
            this.ExternalVoiceId = externalVoiceId;
            this.TtsModelName = ttsModelName;
            this.TtsEmotionControl = ttsEmotionControl;
            this.VoiceSettings = voiceSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLayer" /> class.
        /// </summary>
        public TtsLayer()
        {
        }
    }
}