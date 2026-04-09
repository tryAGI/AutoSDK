//HintName: G.Models.DocumentPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DocumentPayloadDocumentTypeJsonConverter))]
        public global::G.DocumentPayloadDocumentType DocumentType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPayload" /> class.
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <param name="title"></param>
        /// <param name="documentType"></param>
        public DocumentPayload(
            string sourceUrl,
            string title,
            global::G.DocumentPayloadDocumentType documentType)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPayload" /> class.
        /// </summary>
        public DocumentPayload()
        {
        }
    }
}