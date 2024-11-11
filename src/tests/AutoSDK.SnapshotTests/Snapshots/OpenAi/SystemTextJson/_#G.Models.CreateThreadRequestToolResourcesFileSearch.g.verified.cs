//HintName: G.Models.CreateThreadRequestToolResourcesFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearch
    {
        /// <summary>
        /// The [vector store](/docs/api-reference/vector-stores/object) attached to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        public global::System.Collections.Generic.IList<string>? VectorStoreIds { get; set; }

        /// <summary>
        /// A helper to create a [vector store](/docs/api-reference/vector-stores/object) with file_ids and attach it to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_stores")]
        public global::System.Collections.Generic.IList<global::G.CreateThreadRequestToolResourcesFileSearchVectorStore>? VectorStores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearch" /> class.
        /// </summary>
        /// <param name="vectorStoreIds">
        /// The [vector store](/docs/api-reference/vector-stores/object) attached to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </param>
        /// <param name="vectorStores">
        /// A helper to create a [vector store](/docs/api-reference/vector-stores/object) with file_ids and attach it to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateThreadRequestToolResourcesFileSearch(
            global::System.Collections.Generic.IList<string>? vectorStoreIds,
            global::System.Collections.Generic.IList<global::G.CreateThreadRequestToolResourcesFileSearchVectorStore>? vectorStores)
        {
            this.VectorStoreIds = vectorStoreIds;
            this.VectorStores = vectorStores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearch" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearch()
        {
        }
    }
}