//HintName: G.Models.SentimentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SentimentConfigVoiceTypeJsonConverter))]
        public global::G.SentimentConfigVoiceType VoiceType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentConfig" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="voiceType"></param>
        public SentimentConfig(
            string voiceId,
            global::G.SentimentConfigVoiceType voiceType)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceType = voiceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentConfig" /> class.
        /// </summary>
        public SentimentConfig()
        {
        }
    }
}