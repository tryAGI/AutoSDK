//HintName: G.Models.AssetDtoVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DTO for updating an existing asset
    /// </summary>
    public sealed partial class AssetDtoVariant2
    {
        /// <summary>
        /// MIME type of the asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetDtoVariant2MimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetDtoVariant2MimeType MimeType { get; set; }

        /// <summary>
        /// Asset description for LLM context (10-500 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Optional customer-facing name for the asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional metadata tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional thumbnail URL from ephemeral bucket (for video assets)<br/>
        /// Example: s3://bucket-name/path/to/image.jpg
        /// </summary>
        /// <example>s3://bucket-name/path/to/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Asset ID. Required for existing assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Source URL from ephemeral bucket. Optional - only provide when replacing the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDtoVariant2" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// MIME type of the asset
        /// </param>
        /// <param name="description">
        /// Asset description for LLM context (10-500 characters)
        /// </param>
        /// <param name="id">
        /// Asset ID. Required for existing assets.
        /// </param>
        /// <param name="name">
        /// Optional customer-facing name for the asset
        /// </param>
        /// <param name="tags">
        /// Optional metadata tags
        /// </param>
        /// <param name="thumbnailUrl">
        /// Optional thumbnail URL from ephemeral bucket (for video assets)<br/>
        /// Example: s3://bucket-name/path/to/image.jpg
        /// </param>
        /// <param name="sourceUrl">
        /// Source URL from ephemeral bucket. Optional - only provide when replacing the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetDtoVariant2(
            global::G.AssetDtoVariant2MimeType mimeType,
            string description,
            string id,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? thumbnailUrl,
            string? sourceUrl)
        {
            this.MimeType = mimeType;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name;
            this.Tags = tags;
            this.ThumbnailUrl = thumbnailUrl;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDtoVariant2" /> class.
        /// </summary>
        public AssetDtoVariant2()
        {
        }
    }
}