//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStore.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearchVectorStore
    {
        /// <summary>
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunking_strategy")]
        public global::G.OneOf<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1, global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2>? ChunkingStrategy { get; set; }

        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs to add to the vector store. There can be a maximum of 10000 files in a vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStore" /> class.
        /// </summary>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </param>
        /// <param name="fileIds">
        /// A list of [file](/docs/api-reference/files) IDs to add to the vector store. There can be a maximum of 10000 files in a vector store.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public CreateThreadRequestToolResourcesFileSearchVectorStore(
            global::G.OneOf<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1, global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2>? chunkingStrategy,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.ChunkingStrategy = chunkingStrategy;
            this.FileIds = fileIds;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStore" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStore()
        {
        }
    }
}