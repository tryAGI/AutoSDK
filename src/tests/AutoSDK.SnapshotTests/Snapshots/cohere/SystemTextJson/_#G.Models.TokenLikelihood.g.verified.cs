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
        /// Tokenized text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded")]
        public int? Encoded { get; set; }

        /// <summary>
        /// Detokenized text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decoded")]
        public string? Decoded { get; set; }

        /// <summary>
        /// Non normalized probability of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_likelihood")]
        public double? LogLikelihood { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenLikelihood" /> class.
        /// </summary>
        /// <param name="encoded">
        /// Tokenized text
        /// </param>
        /// <param name="decoded">
        /// Detokenized text
        /// </param>
        /// <param name="logLikelihood">
        /// Non normalized probability of the token
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TokenLikelihood(
            int? encoded,
            string? decoded,
            double? logLikelihood)
        {
            this.Encoded = encoded;
            this.Decoded = decoded;
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