//HintName: G.Models.FileSearchStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A `FileSearchStore` is a collection of `Document`s.
    /// </summary>
    public sealed partial class FileSearchStore
    {
        /// <summary>
        /// Output only. Immutable. Identifier. The `FileSearchStore` resource name. It is an ID (name excluding the "fileSearchStores/" prefix) that can contain up to 40 characters that are lowercase alphanumeric or dashes (-). It is output only. The unique name will be derived from `display_name` along with a 12 character random suffix. Example: `fileSearchStores/my-awesome-file-search-store-123a456b789c` If `display_name` is not provided, the name will be randomly generated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. The human-readable display name for the `FileSearchStore`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `FileSearchStore` was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `FileSearchStore` was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Output only. The number of documents in the `FileSearchStore` that are active and ready for retrieval.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("activeDocumentsCount")]
        public string? ActiveDocumentsCount { get; set; }

        /// <summary>
        /// Output only. The number of documents in the `FileSearchStore` that are being processed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pendingDocumentsCount")]
        public string? PendingDocumentsCount { get; set; }

        /// <summary>
        /// Output only. The number of documents in the `FileSearchStore` that have failed processing.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failedDocumentsCount")]
        public string? FailedDocumentsCount { get; set; }

        /// <summary>
        /// Output only. The size of raw bytes ingested into the `FileSearchStore`. This is the total size of all the documents in the `FileSearchStore`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchStore" /> class.
        /// </summary>
        /// <param name="name">
        /// Output only. Immutable. Identifier. The `FileSearchStore` resource name. It is an ID (name excluding the "fileSearchStores/" prefix) that can contain up to 40 characters that are lowercase alphanumeric or dashes (-). It is output only. The unique name will be derived from `display_name` along with a 12 character random suffix. Example: `fileSearchStores/my-awesome-file-search-store-123a456b789c` If `display_name` is not provided, the name will be randomly generated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `FileSearchStore`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="createTime">
        /// Output only. The Timestamp of when the `FileSearchStore` was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The Timestamp of when the `FileSearchStore` was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="activeDocumentsCount">
        /// Output only. The number of documents in the `FileSearchStore` that are active and ready for retrieval.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pendingDocumentsCount">
        /// Output only. The number of documents in the `FileSearchStore` that are being processed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="failedDocumentsCount">
        /// Output only. The number of documents in the `FileSearchStore` that have failed processing.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The size of raw bytes ingested into the `FileSearchStore`. This is the total size of all the documents in the `FileSearchStore`.<br/>
        /// Included only in responses
        /// </param>
        public FileSearchStore(
            string? name,
            string? displayName,
            string? createTime,
            string? updateTime,
            string? activeDocumentsCount,
            string? pendingDocumentsCount,
            string? failedDocumentsCount,
            string? sizeBytes)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.ActiveDocumentsCount = activeDocumentsCount;
            this.PendingDocumentsCount = pendingDocumentsCount;
            this.FailedDocumentsCount = failedDocumentsCount;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchStore" /> class.
        /// </summary>
        public FileSearchStore()
        {
        }
    }
}