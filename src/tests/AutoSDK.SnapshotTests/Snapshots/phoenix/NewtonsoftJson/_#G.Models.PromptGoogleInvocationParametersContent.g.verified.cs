//HintName: G.Models.PromptGoogleInvocationParametersContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptGoogleInvocationParametersContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleInvocationParametersContent" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="stopSequences"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        public PromptGoogleInvocationParametersContent(
            double? temperature,
            int? maxOutputTokens,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? presencePenalty,
            double? frequencyPenalty,
            double? topP,
            int? topK)
        {
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
            this.StopSequences = stopSequences;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.TopP = topP;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleInvocationParametersContent" /> class.
        /// </summary>
        public PromptGoogleInvocationParametersContent()
        {
        }
    }
}