//HintName: G.Models.GetMediaResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMediaResponse
    {
        /// <summary>
        /// The unique langfuse identifier of a media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mediaId", Required = global::Newtonsoft.Json.Required.Always)]
        public string MediaId { get; set; } = default!;

        /// <summary>
        /// The MIME type of the media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// The size of the media record in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentLength", Required = global::Newtonsoft.Json.Required.Always)]
        public long ContentLength { get; set; } = default!;

        /// <summary>
        /// The date and time when the media record was uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UploadedAt { get; set; } = default!;

        /// <summary>
        /// The download URL of the media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The expiry date and time of the media record download URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlExpiry", Required = global::Newtonsoft.Json.Required.Always)]
        public string UrlExpiry { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaResponse" /> class.
        /// </summary>
        /// <param name="mediaId">
        /// The unique langfuse identifier of a media record
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the media record
        /// </param>
        /// <param name="contentLength">
        /// The size of the media record in bytes
        /// </param>
        /// <param name="uploadedAt">
        /// The date and time when the media record was uploaded
        /// </param>
        /// <param name="url">
        /// The download URL of the media record
        /// </param>
        /// <param name="urlExpiry">
        /// The expiry date and time of the media record download URL
        /// </param>
        public GetMediaResponse(
            string mediaId,
            string contentType,
            long contentLength,
            global::System.DateTime uploadedAt,
            string url,
            string urlExpiry)
        {
            this.MediaId = mediaId ?? throw new global::System.ArgumentNullException(nameof(mediaId));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ContentLength = contentLength;
            this.UploadedAt = uploadedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UrlExpiry = urlExpiry ?? throw new global::System.ArgumentNullException(nameof(urlExpiry));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaResponse" /> class.
        /// </summary>
        public GetMediaResponse()
        {
        }
    }
}