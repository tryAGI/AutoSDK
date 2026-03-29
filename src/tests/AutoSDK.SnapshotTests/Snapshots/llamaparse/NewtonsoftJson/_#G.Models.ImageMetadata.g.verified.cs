//HintName: G.Models.ImageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for a single extracted image.
    /// </summary>
    public sealed partial class ImageMetadata
    {
        /// <summary>
        /// Index of the image in the extraction order
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Image filename (e.g., 'image_0.png')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// MIME type of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Size of the image file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Presigned URL to download the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presigned_url")]
        public string? PresignedUrl { get; set; }

        /// <summary>
        /// Image category: 'screenshot' (full page), 'embedded' (images in document), or 'layout' (cropped from layout detection)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public global::G.ImageMetadataCategory2? Category { get; set; }

        /// <summary>
        /// Bounding box of the image on its page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox")]
        public global::G.ImageMetadataBBox2? Bbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadata" /> class.
        /// </summary>
        /// <param name="index">
        /// Index of the image in the extraction order
        /// </param>
        /// <param name="filename">
        /// Image filename (e.g., 'image_0.png')
        /// </param>
        /// <param name="contentType">
        /// MIME type of the image
        /// </param>
        /// <param name="sizeBytes">
        /// Size of the image file in bytes
        /// </param>
        /// <param name="presignedUrl">
        /// Presigned URL to download the image
        /// </param>
        /// <param name="category">
        /// Image category: 'screenshot' (full page), 'embedded' (images in document), or 'layout' (cropped from layout detection)
        /// </param>
        /// <param name="bbox">
        /// Bounding box of the image on its page
        /// </param>
        public ImageMetadata(
            int index,
            string filename,
            string? contentType,
            long? sizeBytes,
            string? presignedUrl,
            global::G.ImageMetadataCategory2? category,
            global::G.ImageMetadataBBox2? bbox)
        {
            this.Index = index;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType;
            this.SizeBytes = sizeBytes;
            this.PresignedUrl = presignedUrl;
            this.Category = category;
            this.Bbox = bbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadata" /> class.
        /// </summary>
        public ImageMetadata()
        {
        }
    }
}