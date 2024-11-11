//HintName: G.Models.ModifyThreadRequestToolResourcesFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyThreadRequestToolResourcesFileSearch
    {
        /// <summary>
        /// The [vector store](/docs/api-reference/vector-stores/object) attached to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_ids")]
        public global::System.Collections.Generic.IList<string>? VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyThreadRequestToolResourcesFileSearch" /> class.
        /// </summary>
        /// <param name="vectorStoreIds">
        /// The [vector store](/docs/api-reference/vector-stores/object) attached to this thread. There can be a maximum of 1 vector store attached to the thread.
        /// </param>
        public ModifyThreadRequestToolResourcesFileSearch(
            global::System.Collections.Generic.IList<string>? vectorStoreIds)
        {
            this.VectorStoreIds = vectorStoreIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyThreadRequestToolResourcesFileSearch" /> class.
        /// </summary>
        public ModifyThreadRequestToolResourcesFileSearch()
        {
        }
    }
}