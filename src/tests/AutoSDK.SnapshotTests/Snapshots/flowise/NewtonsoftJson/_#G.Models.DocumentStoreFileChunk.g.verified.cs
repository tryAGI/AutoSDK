//HintName: G.Models.DocumentStoreFileChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreFileChunk
    {
        /// <summary>
        /// Unique identifier for the file chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Document ID within the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docId")]
        public global::System.Guid? DocId { get; set; }

        /// <summary>
        /// Document Store ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storeId")]
        public global::System.Guid? StoreId { get; set; }

        /// <summary>
        /// Chunk number within the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkNo")]
        public int? ChunkNo { get; set; }

        /// <summary>
        /// Content of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageContent")]
        public string? PageContent { get; set; }

        /// <summary>
        /// Metadata associated with the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreFileChunk" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file chunk
        /// </param>
        /// <param name="docId">
        /// Document ID within the store
        /// </param>
        /// <param name="storeId">
        /// Document Store ID
        /// </param>
        /// <param name="chunkNo">
        /// Chunk number within the document
        /// </param>
        /// <param name="pageContent">
        /// Content of the chunk
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the chunk
        /// </param>
        public DocumentStoreFileChunk(
            global::System.Guid? id,
            global::System.Guid? docId,
            global::System.Guid? storeId,
            int? chunkNo,
            string? pageContent,
            string? metadata)
        {
            this.Id = id;
            this.DocId = docId;
            this.StoreId = storeId;
            this.ChunkNo = chunkNo;
            this.PageContent = pageContent;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreFileChunk" /> class.
        /// </summary>
        public DocumentStoreFileChunk()
        {
        }
    }
}