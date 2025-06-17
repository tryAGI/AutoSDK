//HintName: G.Models.TokenLikelihood.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenLikelihood
    {
        /// <summary>
        /// Detokenized text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("decoded")]
        public string? Decoded { get; set; }

        /// <summary>
        /// Tokenized text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoded")]
        public int? Encoded { get; set; }

        /// <summary>
        /// Non normalized probability of the token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_likelihood")]
        public double? LogLikelihood { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenLikelihood" /> class.
        /// </summary>
        /// <param name="decoded">
        /// Detokenized text
        /// </param>
        /// <param name="encoded">
        /// Tokenized text
        /// </param>
        /// <param name="logLikelihood">
        /// Non normalized probability of the token
        /// </param>
        public TokenLikelihood(
            string? decoded,
            int? encoded,
            double? logLikelihood)
        {
            this.Decoded = decoded;
            this.Encoded = encoded;
            this.LogLikelihood = logLikelihood;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenLikelihood" /> class.
        /// </summary>
        public TokenLikelihood()
        {
        }
    }
}