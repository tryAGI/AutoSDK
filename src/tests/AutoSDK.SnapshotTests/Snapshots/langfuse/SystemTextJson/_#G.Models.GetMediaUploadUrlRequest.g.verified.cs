//HintName: G.Models.GetMediaUploadUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMediaUploadUrlRequest
    {
        /// <summary>
        /// The trace ID associated with the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// The MIME type of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MediaContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MediaContentType ContentType { get; set; }

        /// <summary>
        /// The size of the media record in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// The SHA-256 hash of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256Hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256Hash { get; set; }

        /// <summary>
        /// The trace / observation field the media record is associated with. This can be one of `input`, `output`, `metadata`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="traceId">
        /// The trace ID associated with the media record
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the media record
        /// </param>
        /// <param name="contentLength">
        /// The size of the media record in bytes
        /// </param>
        /// <param name="sha256Hash">
        /// The SHA-256 hash of the media record
        /// </param>
        /// <param name="field">
        /// The trace / observation field the media record is associated with. This can be one of `input`, `output`, `metadata`
        /// </param>
        /// <param name="observationId">
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMediaUploadUrlRequest(
            string traceId,
            global::G.MediaContentType contentType,
            long contentLength,
            string sha256Hash,
            string field,
            string? observationId)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.ObservationId = observationId;
            this.ContentType = contentType;
            this.ContentLength = contentLength;
            this.Sha256Hash = sha256Hash ?? throw new global::System.ArgumentNullException(nameof(sha256Hash));
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlRequest" /> class.
        /// </summary>
        public GetMediaUploadUrlRequest()
        {
        }
    }
}