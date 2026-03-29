//HintName: G.Models.DocumentDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketId")]
        public int? BucketId { get; set; }

        /// <summary>
        /// Unique system generated ID for the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// The file size of the file stored in GroundX<br/>
        /// Example: 1.4MB
        /// </summary>
        /// <example>1.4MB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// The type of document (one of the seven currently supported file types)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentTypeJsonConverter))]
        public global::G.DocumentType? FileType { get; set; }

        /// <summary>
        /// Unique system generated ID for the ingest request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processId")]
        public global::System.Guid? ProcessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchData")]
        public object? SearchData { get; set; }

        /// <summary>
        /// Source document URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProcessingStatusJsonConverter))]
        public global::G.ProcessingStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Document X-Ray results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xrayUrl")]
        public string? XrayUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetail" /> class.
        /// </summary>
        /// <param name="documentId">
        /// Unique system generated ID for the document
        /// </param>
        /// <param name="bucketId"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize">
        /// The file size of the file stored in GroundX<br/>
        /// Example: 1.4MB
        /// </param>
        /// <param name="fileType">
        /// The type of document (one of the seven currently supported file types)
        /// </param>
        /// <param name="processId">
        /// Unique system generated ID for the ingest request
        /// </param>
        /// <param name="searchData"></param>
        /// <param name="sourceUrl">
        /// Source document URL
        /// </param>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
        /// <param name="xrayUrl">
        /// Document X-Ray results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentDetail(
            global::System.Guid documentId,
            int? bucketId,
            string? fileName,
            string? fileSize,
            global::G.DocumentType? fileType,
            global::System.Guid? processId,
            object? searchData,
            string? sourceUrl,
            global::G.ProcessingStatus? status,
            string? statusMessage,
            string? xrayUrl)
        {
            this.BucketId = bucketId;
            this.DocumentId = documentId;
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.FileType = fileType;
            this.ProcessId = processId;
            this.SearchData = searchData;
            this.SourceUrl = sourceUrl;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.XrayUrl = xrayUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetail" /> class.
        /// </summary>
        public DocumentDetail()
        {
        }
    }
}