//HintName: G.Models.CreateThreadAndRunRequestToolResourcesFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadAndRunRequestToolResourcesFileSearch
    {
        /// <summary>
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) attached to this assistant. There can be a maximum of 1 vector store attached to the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        public global::System.Collections.Generic.IList<string?>? VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}