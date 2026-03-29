//HintName: G.Models.DocumentStoreLoaderForUpsert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsert
    {
        /// <summary>
        /// Document ID within the store. If provided, existing configuration from the document will be used for the new document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docId")]
        public global::System.Guid? DocId { get; set; }

        /// <summary>
        /// Metadata associated with the document<br/>
        /// Example: {"foo":"bar"}
        /// </summary>
        /// <example>{"foo":"bar"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether to replace existing document loader with the new upserted chunks. However this does not delete the existing embeddings in the vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replaceExisting")]
        public bool? ReplaceExisting { get; set; }

        /// <summary>
        /// Whether to create a new document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createNewDocStore")]
        public bool? CreateNewDocStore { get; set; }

        /// <summary>
        /// Only when createNewDocStore is true, pass in the new document store configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docStore")]
        public global::G.DocumentStoreLoaderForUpsertDocStore? DocStore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loader")]
        public global::G.DocumentStoreLoaderForUpsertLoader? Loader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splitter")]
        public global::G.DocumentStoreLoaderForUpsertSplitter? Splitter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::G.DocumentStoreLoaderForUpsertEmbedding? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorStore")]
        public global::G.DocumentStoreLoaderForUpsertVectorStore? VectorStore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordManager")]
        public global::G.DocumentStoreLoaderForUpsertRecordManager? RecordManager { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsert" /> class.
        /// </summary>
        /// <param name="docId">
        /// Document ID within the store. If provided, existing configuration from the document will be used for the new document
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the document<br/>
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="replaceExisting">
        /// Whether to replace existing document loader with the new upserted chunks. However this does not delete the existing embeddings in the vector store
        /// </param>
        /// <param name="createNewDocStore">
        /// Whether to create a new document store
        /// </param>
        /// <param name="docStore">
        /// Only when createNewDocStore is true, pass in the new document store configuration
        /// </param>
        /// <param name="loader"></param>
        /// <param name="splitter"></param>
        /// <param name="embedding"></param>
        /// <param name="vectorStore"></param>
        /// <param name="recordManager"></param>
        public DocumentStoreLoaderForUpsert(
            global::System.Guid? docId,
            object? metadata,
            bool? replaceExisting,
            bool? createNewDocStore,
            global::G.DocumentStoreLoaderForUpsertDocStore? docStore,
            global::G.DocumentStoreLoaderForUpsertLoader? loader,
            global::G.DocumentStoreLoaderForUpsertSplitter? splitter,
            global::G.DocumentStoreLoaderForUpsertEmbedding? embedding,
            global::G.DocumentStoreLoaderForUpsertVectorStore? vectorStore,
            global::G.DocumentStoreLoaderForUpsertRecordManager? recordManager)
        {
            this.DocId = docId;
            this.Metadata = metadata;
            this.ReplaceExisting = replaceExisting;
            this.CreateNewDocStore = createNewDocStore;
            this.DocStore = docStore;
            this.Loader = loader;
            this.Splitter = splitter;
            this.Embedding = embedding;
            this.VectorStore = vectorStore;
            this.RecordManager = recordManager;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsert" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsert()
        {
        }
    }
}