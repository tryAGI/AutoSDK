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
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaId { get; set; }

        /// <summary>
        /// The MIME type of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The size of the media record in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// The date and time when the media record was uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UploadedAt { get; set; }

        /// <summary>
        /// The download URL of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The expiry date and time of the media record download URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlExpiry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlExpiry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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