//HintName: G.Models.GoogleRealtimeConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoogleRealtimeConfig
    {
        /// <summary>
        /// This is the nucleus sampling parameter that controls the cumulative probability of tokens considered during text generation.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// This is the top-k sampling parameter that limits the number of highest probability tokens considered during text generation.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// This is the presence penalty parameter that influences the model's likelihood to repeat information by penalizing tokens based on their presence in the text.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// This is the frequency penalty parameter that influences the model's likelihood to repeat tokens by penalizing them based on their frequency in the text.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// This is the speech configuration object that defines the voice settings to be used for the model's speech output.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speechConfig")]
        public global::G.GeminiMultimodalLiveSpeechConfig? SpeechConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleRealtimeConfig" /> class.
        /// </summary>
        /// <param name="topP">
        /// This is the nucleus sampling parameter that controls the cumulative probability of tokens considered during text generation.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </param>
        /// <param name="topK">
        /// This is the top-k sampling parameter that limits the number of highest probability tokens considered during text generation.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </param>
        /// <param name="presencePenalty">
        /// This is the presence penalty parameter that influences the model's likelihood to repeat information by penalizing tokens based on their presence in the text.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </param>
        /// <param name="frequencyPenalty">
        /// This is the frequency penalty parameter that influences the model's likelihood to repeat tokens by penalizing them based on their frequency in the text.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </param>
        /// <param name="speechConfig">
        /// This is the speech configuration object that defines the voice settings to be used for the model's speech output.<br/>
        /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
        /// </param>
        public GoogleRealtimeConfig(
            double? topP,
            double? topK,
            double? presencePenalty,
            double? frequencyPenalty,
            global::G.GeminiMultimodalLiveSpeechConfig? speechConfig)
        {
            this.TopP = topP;
            this.TopK = topK;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.SpeechConfig = speechConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleRealtimeConfig" /> class.
        /// </summary>
        public GoogleRealtimeConfig()
        {
        }
    }
}