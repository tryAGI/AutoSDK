//HintName: G.Models.CountTokensRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Counts the number of tokens in the `prompt` sent to a model. Models may tokenize text differently, so each model may return a different `token_count`.
    /// </summary>
    public sealed partial class CountTokensRequest
    {
        /// <summary>
        /// Required. The input given to the model as a prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.Content>? Contents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}