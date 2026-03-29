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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetType Type { get; set; }

        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// Optional description of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the asset is favorited by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Whether this asset was recently used by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent")]
        public bool? Recent { get; set; }

        /// <summary>
        /// Date the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Date the asset was favorited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorited_at")]
        public string? FavoritedAt { get; set; }

        /// <summary>
        /// The asset itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Asset1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Asset1 Asset1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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