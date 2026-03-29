//HintName: G.Models.RequestAdditionalPresignedURLsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAdditionalPresignedURLsResponse
    {
        /// <summary>
        /// The unique identifier of the upload session associated with these URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// The index of the first chunk number in this set of URLs. Matches the start value from your request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The number of new URLs created. Matches the count value from your request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// An array of additional presigned URLs for uploading chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_urls")]
        public global::System.Collections.Generic.IList<global::G.PresignedURLChunk>? UploadUrls { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when these URLs were created. URLs remain valid for 1 hour from this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public global::System.DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAdditionalPresignedURLsResponse" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// The unique identifier of the upload session associated with these URLs.
        /// </param>
        /// <param name="startIndex">
        /// The index of the first chunk number in this set of URLs. Matches the start value from your request.
        /// </param>
        /// <param name="count">
        /// The number of new URLs created. Matches the count value from your request.
        /// </param>
        /// <param name="uploadUrls">
        /// An array of additional presigned URLs for uploading chunks.
        /// </param>
        /// <param name="generatedAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when these URLs were created. URLs remain valid for 1 hour from this time.
        /// </param>
        /// <param name="expiresAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAdditionalPresignedURLsResponse(
            string? uploadId,
            int? startIndex,
            int? count,
            global::System.Collections.Generic.IList<global::G.PresignedURLChunk>? uploadUrls,
            global::System.DateTime? generatedAt,
            global::System.DateTime? expiresAt)
        {
            this.UploadId = uploadId;
            this.StartIndex = startIndex;
            this.Count = count;
            this.UploadUrls = uploadUrls;
            this.GeneratedAt = generatedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAdditionalPresignedURLsResponse" /> class.
        /// </summary>
        public RequestAdditionalPresignedURLsResponse()
        {
        }
    }
}