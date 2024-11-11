//HintName: G.Models.GenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
    /// </summary>
    public sealed partial class GenerationConfig
    {
        /// <summary>
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function. Values can range from [0.0, infinity).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a stop sequence. The stop sequence will not be included as part of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Note: The default value varies by model, see the `Model.top_k` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits number of tokens based on the cumulative probability. Note: The default value varies by model, see the `Model.top_p` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. Number of generated responses to return. Currently, this value can only be set to 1. If unset, this will default to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidateCount")]
        public int? CandidateCount { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to include in a candidate. Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function. Values can range from [0.0, infinity).
        /// </param>
        /// <param name="stopSequences">
        /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a stop sequence. The stop sequence will not be included as part of the response.
        /// </param>
        /// <param name="topK">
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Note: The default value varies by model, see the `Model.top_k` attribute of the `Model` returned from the `getModel` function.
        /// </param>
        /// <param name="topP">
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits number of tokens based on the cumulative probability. Note: The default value varies by model, see the `Model.top_p` attribute of the `Model` returned from the `getModel` function.
        /// </param>
        /// <param name="candidateCount">
        /// Optional. Number of generated responses to return. Currently, this value can only be set to 1. If unset, this will default to 1.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Optional. The maximum number of tokens to include in a candidate. Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerationConfig(
            float? temperature,
            global::System.Collections.Generic.IList<string>? stopSequences,
            int? topK,
            float? topP,
            int? candidateCount,
            int? maxOutputTokens)
        {
            this.Temperature = temperature;
            this.StopSequences = stopSequences;
            this.TopK = topK;
            this.TopP = topP;
            this.CandidateCount = candidateCount;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        public GenerationConfig()
        {
        }
    }
}