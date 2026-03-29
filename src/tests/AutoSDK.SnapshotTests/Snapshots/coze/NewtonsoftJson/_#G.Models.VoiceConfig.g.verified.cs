//HintName: G.Models.VoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceConfig
    {
        /// <summary>
        /// 音色情感
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_emotion")]
        public string? VoiceEmotion { get; set; }

        /// <summary>
        /// 音色情感值
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_emotion_scale")]
        public double? VoiceEmotionScale { get; set; }

        /// <summary>
        /// 音色ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name")]
        public string? VoiceName { get; set; }

        /// <summary>
        /// 音色场景，如多情感
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_scene")]
        public string? VoiceScene { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceEmotion">
        /// 音色情感
        /// </param>
        /// <param name="voiceEmotionScale">
        /// 音色情感值
        /// </param>
        /// <param name="voiceId">
        /// 音色ID
        /// </param>
        /// <param name="voiceName"></param>
        /// <param name="voiceScene">
        /// 音色场景，如多情感
        /// </param>
        public VoiceConfig(
            string? voiceEmotion,
            double? voiceEmotionScale,
            string? voiceId,
            string? voiceName,
            string? voiceScene)
        {
            this.VoiceEmotion = voiceEmotion;
            this.VoiceEmotionScale = voiceEmotionScale;
            this.VoiceId = voiceId;
            this.VoiceName = voiceName;
            this.VoiceScene = voiceScene;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        public VoiceConfig()
        {
        }
    }
}