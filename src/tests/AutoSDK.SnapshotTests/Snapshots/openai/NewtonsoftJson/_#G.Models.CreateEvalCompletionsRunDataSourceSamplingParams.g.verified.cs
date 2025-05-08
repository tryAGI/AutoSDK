//HintName: G.Models.CreateEvalCompletionsRunDataSourceSamplingParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceSamplingParams
    {
        /// <summary>
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        /// <param name="temperature">
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens in the generated output.
        /// </param>
        /// <param name="topP">
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </param>
        public CreateEvalCompletionsRunDataSourceSamplingParams(
            double? temperature,
            int? maxCompletionTokens,
            double? topP,
            int? seed)
        {
            this.Temperature = temperature;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.TopP = topP;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceSamplingParams()
        {
        }
    }
}