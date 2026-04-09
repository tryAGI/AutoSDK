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
        [global::Newtonsoft.Json.JsonProperty("traceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// The MIME type of the media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MediaContentTypeJsonConverter))]
        public global::G.MediaContentType ContentType { get; set; } = default!;

        /// <summary>
        /// The size of the media record in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentLength", Required = global::Newtonsoft.Json.Required.Always)]
        public long ContentLength { get; set; } = default!;

        /// <summary>
        /// The SHA-256 hash of the media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha256Hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha256Hash { get; set; } = default!;

        /// <summary>
        /// The trace / observation field the media record is associated with. This can be one of `input`, `output`, `metadata`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field", Required = global::Newtonsoft.Json.Required.Always)]
        public string Field { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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