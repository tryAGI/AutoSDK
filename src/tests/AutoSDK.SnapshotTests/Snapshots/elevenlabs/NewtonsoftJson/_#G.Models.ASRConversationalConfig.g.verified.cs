//HintName: G.Models.ASRConversationalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASRConversationalConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public global::G.ASRQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.ASRProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_input_audio_format")]
        public global::G.ASRInputFormat? UserInputAudioFormat { get; set; }

        /// <summary>
        /// Keywords to boost prediction probability for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        /// <param name="quality"></param>
        /// <param name="provider"></param>
        /// <param name="userInputAudioFormat"></param>
        /// <param name="keywords">
        /// Keywords to boost prediction probability for
        /// </param>
        public ASRConversationalConfig(
            global::G.ASRQuality? quality,
            global::G.ASRProvider? provider,
            global::G.ASRInputFormat? userInputAudioFormat,
            global::System.Collections.Generic.IList<string>? keywords)
        {
            this.Quality = quality;
            this.Provider = provider;
            this.UserInputAudioFormat = userInputAudioFormat;
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        public ASRConversationalConfig()
        {
        }
    }
}