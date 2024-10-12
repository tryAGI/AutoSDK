//HintName: G.Models.LogprobsPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogprobsPart
    {
        /// <summary>
        /// List of token IDs corresponding to the logprobs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_ids")]
        public global::System.Collections.Generic.IList<double>? TokenIds { get; set; }

        /// <summary>
        /// List of token log probabilities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_logprobs")]
        public global::System.Collections.Generic.IList<double>? TokenLogprobs { get; set; }

        /// <summary>
        /// List of token strings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}