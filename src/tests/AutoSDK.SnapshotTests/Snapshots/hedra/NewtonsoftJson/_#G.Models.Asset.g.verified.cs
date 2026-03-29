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
        /// The id of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetType Type { get; set; } = default!;

        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// Optional description of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the asset is favorited by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Whether this asset was recently used by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recent")]
        public bool? Recent { get; set; }

        /// <summary>
        /// Date the asset was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Date the asset was favorited.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("favorited_at")]
        public string? FavoritedAt { get; set; }

        /// <summary>
        /// The asset itself.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Asset1 Asset1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the asset.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="thumbnailUrl">
        /// URL of the thumbnail image.
        /// </param>
        /// <param name="createdAt">
        /// Date the asset was created.
        /// </param>
        /// <param name="asset1">
        /// The asset itself.
        /// </param>
        /// <param name="description">
        /// Optional description of the asset.
        /// </param>
        /// <param name="isFavorite">
        /// Whether the asset is favorited by the user.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recent">
        /// Whether this asset was recently used by the user.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="favoritedAt">
        /// Date the asset was favorited.
        /// </param>
        public Asset(
            global::System.Guid id,
            global::G.AssetType type,
            string name,
            string thumbnailUrl,
            string createdAt,
            global::G.Asset1 asset1,
            string? description,
            bool? isFavorite,
            bool? recent,
            string? favoritedAt)
        {
            this.Id = id;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.Description = description;
            this.IsFavorite = isFavorite;
            this.Recent = recent;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.FavoritedAt = favoritedAt;
            this.Asset1 = asset1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }
    }
}