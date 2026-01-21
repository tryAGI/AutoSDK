//HintName: G.Models.SingleGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("likelihood")]
        public double? Likelihood { get; set; }

        /// <summary>
        /// Only returned if `return_likelihoods` is set to `GENERATION` or `ALL`. The likelihood refers to the average log-likelihood of the entire specified string, which is useful for [evaluating the performance of your model](likelihood-eval), especially if you've created a [custom model](https://docs.cohere.com/docs/training-custom-models). Individual token likelihoods provide the log-likelihood of each token. The first token will not have a likelihood.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_likelihoods")]
        public global::System.Collections.Generic.IList<global::G.SingleGenerationTokenLikelihood>? TokenLikelihoods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGeneration" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </param>
        /// <param name="likelihood"></param>
        /// <param name="tokenLikelihoods">
        /// Only returned if `return_likelihoods` is set to `GENERATION` or `ALL`. The likelihood refers to the average log-likelihood of the entire specified string, which is useful for [evaluating the performance of your model](likelihood-eval), especially if you've created a [custom model](https://docs.cohere.com/docs/training-custom-models). Individual token likelihoods provide the log-likelihood of each token. The first token will not have a likelihood.
        /// </param>
        public SingleGeneration(
            string id,
            string text,
            int? index,
            double? likelihood,
            global::System.Collections.Generic.IList<global::G.SingleGenerationTokenLikelihood>? tokenLikelihoods)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Index = index;
            this.Likelihood = likelihood;
            this.TokenLikelihoods = tokenLikelihoods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGeneration" /> class.
        /// </summary>
        public SingleGeneration()
        {
        }
    }
}