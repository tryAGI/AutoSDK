//HintName: G.Models.LogLikelihoodResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogLikelihoodResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Probabilities for tokens in the request prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TokenLikelihood> PromptTokens { get; set; }

        /// <summary>
        /// Probabilities for tokens in the request completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TokenLikelihood> CompletionTokens { get; set; }

        /// <summary>
        /// Probabilities for tokens in the request raw_prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TokenLikelihood> RawPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogLikelihoodResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptTokens">
        /// Probabilities for tokens in the request prompt
        /// </param>
        /// <param name="completionTokens">
        /// Probabilities for tokens in the request completion
        /// </param>
        /// <param name="rawPromptTokens">
        /// Probabilities for tokens in the request raw_prompt
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogLikelihoodResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> promptTokens,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> completionTokens,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> rawPromptTokens,
            global::G.ApiMeta? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptTokens = promptTokens ?? throw new global::System.ArgumentNullException(nameof(promptTokens));
            this.CompletionTokens = completionTokens ?? throw new global::System.ArgumentNullException(nameof(completionTokens));
            this.RawPromptTokens = rawPromptTokens ?? throw new global::System.ArgumentNullException(nameof(rawPromptTokens));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogLikelihoodResponse" /> class.
        /// </summary>
        public LogLikelihoodResponse()
        {
        }
    }
}