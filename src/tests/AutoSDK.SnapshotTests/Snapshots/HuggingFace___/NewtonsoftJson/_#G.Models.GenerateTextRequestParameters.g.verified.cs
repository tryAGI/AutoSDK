//HintName: G.Models.GenerateTextRequestParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextRequestParameters
    {
        /// <summary>
        /// Integer to define the top tokens considered within the sample operation to create new text.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Float to define the tokens that are within the sample operation of text generation.<br/>
        /// Add tokens in the sample for more probable to least probable until the sum of the probabilities is greater than top_p.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The temperature of the sampling operation.<br/>
        /// 1 means regular sampling,<br/>
        /// 0 means always take the highest score,<br/>
        /// 100.0 is getting closer to uniform probability.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The more a token is used within generation the more it is penalized to not be picked in successive generation passes.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// The amount of new tokens to be generated, this does not include the input length it is a estimate of the size of generated text you want.<br/>
        /// Each new tokens slows down the request, so look for balance between response times and length of text generated.<br/>
        /// Example: 250
        /// </summary>
        /// <example>250</example>
        [global::Newtonsoft.Json.JsonProperty("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// The amount of time in seconds that the query should take maximum. Network can cause some overhead so it will be a soft limit. Use that in combination with max_new_tokens for best results.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("max_time")]
        public double? MaxTime { get; set; }

        /// <summary>
        /// If set to False, the return results will not contain the original query making it easier for prompting.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_full_text")]
        public object? ReturnFullText { get; set; }

        /// <summary>
        /// The number of proposition you want to be returned.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("num_return_sequences")]
        public int? NumReturnSequences { get; set; }

        /// <summary>
        /// Whether or not to use sampling, use greedy decoding otherwise.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do_sample")]
        public object? DoSample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequestParameters" /> class.
        /// </summary>
        /// <param name="topK">
        /// Integer to define the top tokens considered within the sample operation to create new text.<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Float to define the tokens that are within the sample operation of text generation.<br/>
        /// Add tokens in the sample for more probable to least probable until the sum of the probabilities is greater than top_p.<br/>
        /// Example: 1
        /// </param>
        /// <param name="temperature">
        /// The temperature of the sampling operation.<br/>
        /// 1 means regular sampling,<br/>
        /// 0 means always take the highest score,<br/>
        /// 100.0 is getting closer to uniform probability.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="repetitionPenalty">
        /// The more a token is used within generation the more it is penalized to not be picked in successive generation passes.<br/>
        /// Example: 1
        /// </param>
        /// <param name="maxNewTokens">
        /// The amount of new tokens to be generated, this does not include the input length it is a estimate of the size of generated text you want.<br/>
        /// Each new tokens slows down the request, so look for balance between response times and length of text generated.<br/>
        /// Example: 250
        /// </param>
        /// <param name="maxTime">
        /// The amount of time in seconds that the query should take maximum. Network can cause some overhead so it will be a soft limit. Use that in combination with max_new_tokens for best results.<br/>
        /// Example: 1
        /// </param>
        /// <param name="returnFullText">
        /// If set to False, the return results will not contain the original query making it easier for prompting.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="numReturnSequences">
        /// The number of proposition you want to be returned.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="doSample">
        /// Whether or not to use sampling, use greedy decoding otherwise.<br/>
        /// Default Value: true
        /// </param>
        public GenerateTextRequestParameters(
            int? topK,
            double? topP,
            double? temperature,
            double? repetitionPenalty,
            int? maxNewTokens,
            double? maxTime,
            object? returnFullText,
            int? numReturnSequences,
            object? doSample)
        {
            this.TopK = topK;
            this.TopP = topP;
            this.Temperature = temperature;
            this.RepetitionPenalty = repetitionPenalty;
            this.MaxNewTokens = maxNewTokens;
            this.MaxTime = maxTime;
            this.ReturnFullText = returnFullText;
            this.NumReturnSequences = numReturnSequences;
            this.DoSample = doSample;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequestParameters" /> class.
        /// </summary>
        public GenerateTextRequestParameters()
        {
        }
    }
}