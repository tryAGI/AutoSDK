//HintName: G.Models.KnowledgeBaseDocumentMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseDocumentMetadataResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastUpdatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseDocumentMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="lastUpdatedAtUnixSecs"></param>
        /// <param name="sizeBytes"></param>
        public KnowledgeBaseDocumentMetadataResponseModel(
            int createdAtUnixSecs,
            int lastUpdatedAtUnixSecs,
            int sizeBytes)
        {
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.LastUpdatedAtUnixSecs = lastUpdatedAtUnixSecs;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseDocumentMetadataResponseModel" /> class.
        /// </summary>
        public KnowledgeBaseDocumentMetadataResponseModel()
        {
        }
    }
}