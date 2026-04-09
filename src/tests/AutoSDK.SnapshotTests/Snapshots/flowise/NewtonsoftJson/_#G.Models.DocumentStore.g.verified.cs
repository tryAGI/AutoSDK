//HintName: G.Models.DocumentStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStore
    {
        /// <summary>
        /// Unique identifier for the document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Loaders associated with the document store, stored as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loaders")]
        public string? Loaders { get; set; }

        /// <summary>
        /// Places where the document store is used, stored as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whereUsed")]
        public string? WhereUsed { get; set; }

        /// <summary>
        /// Status of the document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DocumentStoreStatusJsonConverter))]
        public global::G.DocumentStoreStatus? Status { get; set; }

        /// <summary>
        /// Configuration for the vector store, stored as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorStoreConfig")]
        public string? VectorStoreConfig { get; set; }

        /// <summary>
        /// Configuration for the embedding, stored as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddingConfig")]
        public string? EmbeddingConfig { get; set; }

        /// <summary>
        /// Configuration for the record manager, stored as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordManagerConfig")]
        public string? RecordManagerConfig { get; set; }

        /// <summary>
        /// Date and time when the document store was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time when the document store was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStore" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the document store
        /// </param>
        /// <param name="name">
        /// Name of the document store
        /// </param>
        /// <param name="description">
        /// Description of the document store
        /// </param>
        /// <param name="loaders">
        /// Loaders associated with the document store, stored as JSON string
        /// </param>
        /// <param name="whereUsed">
        /// Places where the document store is used, stored as JSON string
        /// </param>
        /// <param name="status">
        /// Status of the document store
        /// </param>
        /// <param name="vectorStoreConfig">
        /// Configuration for the vector store, stored as JSON string
        /// </param>
        /// <param name="embeddingConfig">
        /// Configuration for the embedding, stored as JSON string
        /// </param>
        /// <param name="recordManagerConfig">
        /// Configuration for the record manager, stored as JSON string
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the document store was created
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the document store was last updated
        /// </param>
        public DocumentStore(
            global::System.Guid? id,
            string? name,
            string? description,
            string? loaders,
            string? whereUsed,
            global::G.DocumentStoreStatus? status,
            string? vectorStoreConfig,
            string? embeddingConfig,
            string? recordManagerConfig,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Loaders = loaders;
            this.WhereUsed = whereUsed;
            this.Status = status;
            this.VectorStoreConfig = vectorStoreConfig;
            this.EmbeddingConfig = embeddingConfig;
            this.RecordManagerConfig = recordManagerConfig;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStore" /> class.
        /// </summary>
        public DocumentStore()
        {
        }
    }
}