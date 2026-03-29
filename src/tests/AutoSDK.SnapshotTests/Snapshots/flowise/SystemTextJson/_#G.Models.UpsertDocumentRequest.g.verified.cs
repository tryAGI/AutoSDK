//HintName: G.Models.UpsertDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertDocumentRequest
    {
        /// <summary>
        /// Files to be uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Document ID to use existing configuration<br/>
        /// Example: 603a7b51-ae7c-4b0a-8865-e454ed2f6766
        /// </summary>
        /// <example>603a7b51-ae7c-4b0a-8865-e454ed2f6766</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("docId")]
        public string? DocId { get; set; }

        /// <summary>
        /// Loader configurations<br/>
        /// Example: {"name":"plainText","config":{"text":"why the sky is blue"}}
        /// </summary>
        /// <example>{"name":"plainText","config":{"text":"why the sky is blue"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loader")]
        public string? Loader { get; set; }

        /// <summary>
        /// Splitter configurations<br/>
        /// Example: {"name":"recursiveCharacterTextSplitter","config":{"chunkSize":2000}}
        /// </summary>
        /// <example>{"name":"recursiveCharacterTextSplitter","config":{"chunkSize":2000}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitter")]
        public string? Splitter { get; set; }

        /// <summary>
        /// Embedding configurations<br/>
        /// Example: {"name":"openAIEmbeddings","config":{"modelName":"text-embedding-ada-002"}}
        /// </summary>
        /// <example>{"name":"openAIEmbeddings","config":{"modelName":"text-embedding-ada-002"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// Vector Store configurations<br/>
        /// Example: {"name":"faiss"}
        /// </summary>
        /// <example>{"name":"faiss"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorStore")]
        public string? VectorStore { get; set; }

        /// <summary>
        /// Record Manager configurations<br/>
        /// Example: {"name":"postgresRecordManager"}
        /// </summary>
        /// <example>{"name":"postgresRecordManager"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordManager")]
        public string? RecordManager { get; set; }

        /// <summary>
        /// Metadata associated with the document<br/>
        /// Example: {"foo":"bar"}
        /// </summary>
        /// <example>{"foo":"bar"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether to replace existing document loader with the new upserted chunks. However this does not delete the existing embeddings in the vector store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaceExisting")]
        public bool? ReplaceExisting { get; set; }

        /// <summary>
        /// Whether to create a new document store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createNewDocStore")]
        public bool? CreateNewDocStore { get; set; }

        /// <summary>
        /// Only when createNewDocStore is true, pass in the new document store configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docStore")]
        public global::G.UpsertDocumentRequestDocStore? DocStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertDocumentRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Files to be uploaded
        /// </param>
        /// <param name="docId">
        /// Document ID to use existing configuration<br/>
        /// Example: 603a7b51-ae7c-4b0a-8865-e454ed2f6766
        /// </param>
        /// <param name="loader">
        /// Loader configurations<br/>
        /// Example: {"name":"plainText","config":{"text":"why the sky is blue"}}
        /// </param>
        /// <param name="splitter">
        /// Splitter configurations<br/>
        /// Example: {"name":"recursiveCharacterTextSplitter","config":{"chunkSize":2000}}
        /// </param>
        /// <param name="embedding">
        /// Embedding configurations<br/>
        /// Example: {"name":"openAIEmbeddings","config":{"modelName":"text-embedding-ada-002"}}
        /// </param>
        /// <param name="vectorStore">
        /// Vector Store configurations<br/>
        /// Example: {"name":"faiss"}
        /// </param>
        /// <param name="recordManager">
        /// Record Manager configurations<br/>
        /// Example: {"name":"postgresRecordManager"}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertDocumentRequest(
            global::System.Collections.Generic.IList<byte[]> files,
            string? docId,
            string? loader,
            string? splitter,
            string? embedding,
            string? vectorStore,
            string? recordManager,
            object? metadata,
            bool? replaceExisting,
            bool? createNewDocStore,
            global::G.UpsertDocumentRequestDocStore? docStore)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.DocId = docId;
            this.Loader = loader;
            this.Splitter = splitter;
            this.Embedding = embedding;
            this.VectorStore = vectorStore;
            this.RecordManager = recordManager;
            this.Metadata = metadata;
            this.ReplaceExisting = replaceExisting;
            this.CreateNewDocStore = createNewDocStore;
            this.DocStore = docStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertDocumentRequest" /> class.
        /// </summary>
        public UpsertDocumentRequest()
        {
        }
    }
}