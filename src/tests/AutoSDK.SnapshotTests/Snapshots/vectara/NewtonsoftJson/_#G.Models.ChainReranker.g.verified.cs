//HintName: G.Models.ChainReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChainReranker
    {
        /// <summary>
        /// When the type is `chain`, you can then chain re-rankers together.<br/>
        /// Default Value: chain
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "chain";

        /// <summary>
        /// Specify an array of rerankers to apply to search results consecutively.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerankers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchReranker> Rerankers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}