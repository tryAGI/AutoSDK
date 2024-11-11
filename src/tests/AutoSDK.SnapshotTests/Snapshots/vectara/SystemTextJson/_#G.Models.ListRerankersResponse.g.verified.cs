//HintName: G.Models.ListRerankersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRerankersResponse
    {
        /// <summary>
        /// An array of rerankers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerankers")]
        public global::System.Collections.Generic.IList<global::G.Reranker>? Rerankers { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRerankersResponse" /> class.
        /// </summary>
        /// <param name="rerankers">
        /// An array of rerankers.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListRerankersResponse(
            global::System.Collections.Generic.IList<global::G.Reranker>? rerankers,
            global::G.ListMetadata? metadata)
        {
            this.Rerankers = rerankers;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRerankersResponse" /> class.
        /// </summary>
        public ListRerankersResponse()
        {
        }
    }
}