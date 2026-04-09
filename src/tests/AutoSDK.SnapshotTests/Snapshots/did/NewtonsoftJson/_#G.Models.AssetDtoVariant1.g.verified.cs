//HintName: G.Models.AssetDtoVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DTO for creating a new asset
    /// </summary>
    public sealed partial class AssetDtoVariant1
    {
        /// <summary>
        /// MIME type of the asset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssetDtoVariant1MimeTypeJsonConverter))]
        public global::G.AssetDtoVariant1MimeType MimeType { get; set; } = default!;

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
        /// Optional thumbnail URL from ephemeral bucket (for video assets)<br/>
        /// Example: s3://bucket-name/path/to/image.jpg
        /// </summary>
        /// <example>s3://bucket-name/path/to/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Source URL from ephemeral bucket. Required for new assets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDtoVariant1" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// MIME type of the asset
        /// </param>
        /// <param name="description">
        /// Asset description for LLM context (10-500 characters)
        /// </param>
        /// <param name="sourceUrl">
        /// Source URL from ephemeral bucket. Required for new assets.
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
        public AssetDtoVariant1(
            global::G.AssetDtoVariant1MimeType mimeType,
            string description,
            string sourceUrl,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? thumbnailUrl)
        {
            this.MimeType = mimeType;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name;
            this.Tags = tags;
            this.ThumbnailUrl = thumbnailUrl;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDtoVariant1" /> class.
        /// </summary>
        public AssetDtoVariant1()
        {
        }
    }
}