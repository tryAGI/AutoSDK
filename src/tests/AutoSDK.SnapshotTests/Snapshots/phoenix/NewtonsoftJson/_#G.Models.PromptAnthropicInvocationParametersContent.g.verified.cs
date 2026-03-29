//HintName: G.Models.PromptAnthropicInvocationParametersContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicInvocationParametersContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking")]
        public global::G.Thinking? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContent" /> class.
        /// </summary>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stopSequences"></param>
        /// <param name="thinking"></param>
        public PromptAnthropicInvocationParametersContent(
            int maxTokens,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::G.Thinking? thinking)
        {
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.StopSequences = stopSequences;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContent" /> class.
        /// </summary>
        public PromptAnthropicInvocationParametersContent()
        {
        }
    }
}