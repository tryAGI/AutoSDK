//HintName: G.Models.GetDocumentsResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentsResponseItem
    {
        /// <summary>
        /// File format of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDocumentsResponseItemDocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetDocumentsResponseItemDocumentType DocumentType { get; set; }

        /// <summary>
        /// Type of object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDocumentsResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetDocumentsResponseItemType Type { get; set; }

        /// <summary>
        /// URL of Document for upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceUrl { get; set; }

        /// <summary>
        /// URL of the parsed document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParsedUrl { get; set; }

        /// <summary>
        /// User that upload document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDocumentsResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetDocumentsResponseItemStatus Status { get; set; }

        /// <summary>
        /// Title to display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Object in case of if error appears
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Callback to call when the document is uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentsResponseItem" /> class.
        /// </summary>
        /// <param name="documentType">
        /// File format of the file
        /// </param>
        /// <param name="type">
        /// Type of object
        /// </param>
        /// <param name="sourceUrl">
        /// URL of Document for upload
        /// </param>
        /// <param name="parsedUrl">
        /// URL of the parsed document
        /// </param>
        /// <param name="createdBy">
        /// User that upload document
        /// </param>
        /// <param name="status"></param>
        /// <param name="title">
        /// Title to display
        /// </param>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="error">
        /// Object in case of if error appears
        /// </param>
        /// <param name="webhook">
        /// Callback to call when the document is uploaded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentsResponseItem(
            global::G.GetDocumentsResponseItemDocumentType documentType,
            global::G.GetDocumentsResponseItemType type,
            string sourceUrl,
            string parsedUrl,
            string createdBy,
            global::G.GetDocumentsResponseItemStatus status,
            string title,
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            string? error,
            string? webhook)
        {
            this.DocumentType = documentType;
            this.Type = type;
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.ParsedUrl = parsedUrl ?? throw new global::System.ArgumentNullException(nameof(parsedUrl));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Status = status;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Error = error;
            this.Webhook = webhook;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentsResponseItem" /> class.
        /// </summary>
        public GetDocumentsResponseItem()
        {
        }
    }
}