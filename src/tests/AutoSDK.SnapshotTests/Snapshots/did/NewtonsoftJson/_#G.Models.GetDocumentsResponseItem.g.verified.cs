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
        [global::Newtonsoft.Json.JsonProperty("documentType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetDocumentsResponseItemDocumentType DocumentType { get; set; } = default!;

        /// <summary>
        /// Type of object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetDocumentsResponseItemType Type { get; set; } = default!;

        /// <summary>
        /// URL of Document for upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// URL of the parsed document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ParsedUrl { get; set; } = default!;

        /// <summary>
        /// User that upload document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetDocumentsResponseItemStatus Status { get; set; } = default!;

        /// <summary>
        /// Title to display
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Object in case of if error appears
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Callback to call when the document is uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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