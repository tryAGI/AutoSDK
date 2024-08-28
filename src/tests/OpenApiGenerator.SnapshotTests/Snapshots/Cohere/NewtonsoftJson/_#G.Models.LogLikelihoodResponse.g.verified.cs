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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> PromptTokens { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request raw_prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> RawPromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}