//HintName: G.Models.Asset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Asset
    {
        /// <summary>
        /// Asset ID. Present for existing assets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// MIME type of the asset (e.g., 'image/png', 'video/mp4')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Cloud provider where the asset is stored
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloud_provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssetCloudProviderJsonConverter))]
        public global::G.AssetCloudProvider CloudProvider { get; set; } = default!;

        /// <summary>
        /// Storage key (path) for the asset in cloud storage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string StorageUri { get; set; } = default!;

        /// <summary>
        /// Asset description for LLM context (10-500 characters)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Optional customer-facing name for the asset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional metadata tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional thumbnail CDN URL for video assets
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Current status for this asset lifecycle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssetStatus2JsonConverter))]
        public global::G.AssetStatus2? Status { get; set; }

        /// <summary>
        /// Moderation error details when status is error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AssetError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">
        /// Asset ID. Present for existing assets.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the asset (e.g., 'image/png', 'video/mp4')
        /// </param>
        /// <param name="cloudProvider">
        /// Cloud provider where the asset is stored
        /// </param>
        /// <param name="storageUri">
        /// Storage key (path) for the asset in cloud storage
        /// </param>
        /// <param name="description">
        /// Asset description for LLM context (10-500 characters)
        /// </param>
        /// <param name="name">
        /// Optional customer-facing name for the asset
        /// </param>
        /// <param name="tags">
        /// Optional metadata tags
        /// </param>
        /// <param name="thumbnailUrl">
        /// Optional thumbnail CDN URL for video assets
        /// </param>
        /// <param name="status">
        /// Current status for this asset lifecycle
        /// </param>
        /// <param name="error">
        /// Moderation error details when status is error
        /// </param>
        public Asset(
            string id,
            string mimeType,
            global::G.AssetCloudProvider cloudProvider,
            string storageUri,
            string description,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? thumbnailUrl,
            global::G.AssetStatus2? status,
            global::G.AssetError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.CloudProvider = cloudProvider;
            this.StorageUri = storageUri ?? throw new global::System.ArgumentNullException(nameof(storageUri));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name;
            this.Tags = tags;
            this.ThumbnailUrl = thumbnailUrl;
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }
    }
}