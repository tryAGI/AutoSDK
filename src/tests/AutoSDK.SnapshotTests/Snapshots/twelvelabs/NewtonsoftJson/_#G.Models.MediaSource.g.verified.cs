//HintName: G.Models.MediaSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
    /// </summary>
    public sealed partial class MediaSource
    {
        /// <summary>
        /// The base64-encoded media data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// The publicly accessible URL of the media file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSource" /> class.
        /// </summary>
        /// <param name="base64String">
        /// The base64-encoded media data.
        /// </param>
        /// <param name="url">
        /// The publicly accessible URL of the media file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </param>
        public MediaSource(
            string? base64String,
            string? url,
            string? assetId)
        {
            this.Base64String = base64String;
            this.Url = url;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSource" /> class.
        /// </summary>
        public MediaSource()
        {
        }
    }
}