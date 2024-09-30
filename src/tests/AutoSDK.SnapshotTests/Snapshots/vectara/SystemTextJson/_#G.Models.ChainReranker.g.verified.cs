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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "chain";

        /// <summary>
        /// Specify an array of rerankers to search results consecutively after each other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerankers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchReranker> Rerankers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}