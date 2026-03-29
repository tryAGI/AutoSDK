//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A `Document` is a collection of `Chunk`s.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Immutable. Identifier. The `Document` resource name. The ID (name excluding the "fileSearchStores/*/documents/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `fileSearchStores/{file_search_store_id}/documents/my-awesome-doc-123a456b789c`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. The human-readable display name for the `Document`. The display name must be no more than 512 characters in length, including spaces. Example: "Semantic Retriever Documentation"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional. User provided custom metadata stored as key-value pairs used for querying. A `Document` can have a maximum of 20 `CustomMetadata`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customMetadata")]
        public global::System.Collections.Generic.IList<global::G.CustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `Document` was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `Document` was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. Current state of the `Document`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.DocumentState? State { get; set; }

        /// <summary>
        /// Output only. The size of raw bytes ingested into the Document.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Output only. The mime type of the Document.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="name">
        /// Immutable. Identifier. The `Document` resource name. The ID (name excluding the "fileSearchStores/*/documents/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `fileSearchStores/{file_search_store_id}/documents/my-awesome-doc-123a456b789c`
        /// </param>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `Document`. The display name must be no more than 512 characters in length, including spaces. Example: "Semantic Retriever Documentation"
        /// </param>
        /// <param name="customMetadata">
        /// Optional. User provided custom metadata stored as key-value pairs used for querying. A `Document` can have a maximum of 20 `CustomMetadata`.
        /// </param>
        /// <param name="updateTime">
        /// Output only. The Timestamp of when the `Document` was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Output only. The Timestamp of when the `Document` was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Output only. Current state of the `Document`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The size of raw bytes ingested into the Document.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="mimeType">
        /// Output only. The mime type of the Document.<br/>
        /// Included only in responses
        /// </param>
        public Document(
            string? name,
            string? displayName,
            global::System.Collections.Generic.IList<global::G.CustomMetadata>? customMetadata,
            string? updateTime,
            string? createTime,
            global::G.DocumentState? state,
            string? sizeBytes,
            string? mimeType)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.CustomMetadata = customMetadata;
            this.UpdateTime = updateTime;
            this.CreateTime = createTime;
            this.State = state;
            this.SizeBytes = sizeBytes;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}