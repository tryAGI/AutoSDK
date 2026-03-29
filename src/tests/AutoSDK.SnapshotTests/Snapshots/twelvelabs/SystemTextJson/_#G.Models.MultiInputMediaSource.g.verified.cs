//HintName: G.Models.MultiInputMediaSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying an image source for multi-input embeddings. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
    /// </summary>
    public sealed partial class MultiInputMediaSource
    {
        /// <summary>
        /// The unique identifier for this media source.<br/>
        /// This field is required when `input_type` references this image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of media.<br/>
        /// **Value**: `image`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter))]
        public global::G.MultiInputMediaSourceMediaType MediaType { get; set; }

        /// <summary>
        /// The publicly accessible URL of the image file  Use direct links to raw image files. Image hosting platforms and cloud storage sharing links are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The base64-encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputMediaSource" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique identifier for this media source.<br/>
        /// This field is required when `input_type` references this image.
        /// </param>
        /// <param name="mediaType">
        /// The type of media.<br/>
        /// **Value**: `image`
        /// </param>
        /// <param name="url">
        /// The publicly accessible URL of the image file  Use direct links to raw image files. Image hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="base64String">
        /// The base64-encoded image data.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiInputMediaSource(
            string? name,
            global::G.MultiInputMediaSourceMediaType mediaType,
            string? url,
            string? base64String,
            string? assetId)
        {
            this.Name = name;
            this.MediaType = mediaType;
            this.Url = url;
            this.Base64String = base64String;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputMediaSource" /> class.
        /// </summary>
        public MultiInputMediaSource()
        {
        }
    }
}