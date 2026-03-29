//HintName: G.Models.AudioConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_message_type")]
        public int? AgentMessageType { get; set; }

        /// <summary>
        /// 文本转语音开关
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_text_to_voice_enable")]
        public bool? IsTextToVoiceEnable { get; set; }

        /// <summary>
        /// key为语言 "zh", "en" "ja" "es" "id" "pt"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_config_map")]
        public global::System.Collections.Generic.Dictionary<string, global::G.VoiceConfig>? VoiceConfigMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        /// <param name="agentMessageType"></param>
        /// <param name="isTextToVoiceEnable">
        /// 文本转语音开关
        /// </param>
        /// <param name="voiceConfigMap">
        /// key为语言 "zh", "en" "ja" "es" "id" "pt"
        /// </param>
        public AudioConfig(
            int? agentMessageType,
            bool? isTextToVoiceEnable,
            global::System.Collections.Generic.Dictionary<string, global::G.VoiceConfig>? voiceConfigMap)
        {
            this.AgentMessageType = agentMessageType;
            this.IsTextToVoiceEnable = isTextToVoiceEnable;
            this.VoiceConfigMap = voiceConfigMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        public AudioConfig()
        {
        }
    }
}