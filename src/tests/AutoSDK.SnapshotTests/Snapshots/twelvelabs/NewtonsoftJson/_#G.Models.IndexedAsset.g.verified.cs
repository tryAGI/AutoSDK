//HintName: G.Models.IndexedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An indexed asset object that contains information about the indexed asset, including its indexing status.
    /// </summary>
    public sealed partial class IndexedAsset
    {
        /// <summary>
        /// A string representing the unique identifier of your indexed asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was last updated. The platform updates this field every time the indexing task transitions to a different state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task has been completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed_at")]
        public string? IndexedAt { get; set; }

        /// <summary>
        /// The status of the indexing task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.IndexedAssetStatus? Status { get; set; }

        /// <summary>
        /// System-generated metadata about the indexed asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_metadata")]
        public global::G.IndexedAssetSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAsset" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of your indexed asset.
        /// </param>
        /// <param name="createdAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was last updated. The platform updates this field every time the indexing task transitions to a different state.
        /// </param>
        /// <param name="indexedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task has been completed.
        /// </param>
        /// <param name="status">
        /// The status of the indexing task.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated metadata about the indexed asset.
        /// </param>
        public IndexedAsset(
            string? id,
            string? createdAt,
            string? updatedAt,
            string? indexedAt,
            global::G.IndexedAssetStatus? status,
            global::G.IndexedAssetSystemMetadata? systemMetadata)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IndexedAt = indexedAt;
            this.Status = status;
            this.SystemMetadata = systemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAsset" /> class.
        /// </summary>
        public IndexedAsset()
        {
        }
    }
}