//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantRequestToolResourcesFileSearch
    {
        /// <summary>
        /// The [vector store](/docs/api-reference/vector-stores/object) attached to this assistant. There can be a maximum of 1 vector store attached to the assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_ids")]
        public global::System.Collections.Generic.IList<string>? VectorStoreIds { get; set; }

        /// <summary>
        /// A helper to create a [vector store](/docs/api-reference/vector-stores/object) with file_ids and attach it to this assistant. There can be a maximum of 1 vector store attached to the assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_stores")]
        public global::System.Collections.Generic.IList<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStore>? VectorStores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}