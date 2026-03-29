//HintName: G.Models.UploadToFileSearchStoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for `UploadToFileSearchStore`.
    /// </summary>
    public sealed partial class UploadToFileSearchStoreRequest
    {
        /// <summary>
        /// Optional. Display name of the created document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Custom metadata to be associated with the data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customMetadata")]
        public global::System.Collections.Generic.IList<global::G.CustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkingConfig")]
        public global::G.ChunkingConfig? ChunkingConfig { get; set; }

        /// <summary>
        /// Optional. MIME type of the data. If not provided, it will be inferred from the uploaded content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadToFileSearchStoreRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Optional. Display name of the created document.
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the data.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="mimeType">
        /// Optional. MIME type of the data. If not provided, it will be inferred from the uploaded content.
        /// </param>
        public UploadToFileSearchStoreRequest(
            string? displayName,
            global::System.Collections.Generic.IList<global::G.CustomMetadata>? customMetadata,
            global::G.ChunkingConfig? chunkingConfig,
            string? mimeType)
        {
            this.DisplayName = displayName;
            this.CustomMetadata = customMetadata;
            this.ChunkingConfig = chunkingConfig;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadToFileSearchStoreRequest" /> class.
        /// </summary>
        public UploadToFileSearchStoreRequest()
        {
        }
    }
}