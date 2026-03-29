//HintName: G.Models.DocumentStoreLoaderForUpsertVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsertVectorStore
    {
        /// <summary>
        /// Name of the vector store (camelCase)<br/>
        /// Example: faiss
        /// </summary>
        /// <example>faiss</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configuration for the vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertVectorStore" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the vector store (camelCase)<br/>
        /// Example: faiss
        /// </param>
        /// <param name="config">
        /// Configuration for the vector store
        /// </param>
        public DocumentStoreLoaderForUpsertVectorStore(
            string? name,
            object? config)
        {
            this.Name = name;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertVectorStore" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsertVectorStore()
        {
        }
    }
}