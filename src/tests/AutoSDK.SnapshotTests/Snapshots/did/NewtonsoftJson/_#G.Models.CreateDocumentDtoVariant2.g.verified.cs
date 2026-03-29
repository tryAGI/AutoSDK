//HintName: G.Models.CreateDocumentDtoVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class CreateDocumentDtoVariant2
    {
        /// <summary>
        /// URL of Document for upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Title to display
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Callback to call when the document is uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentDtoVariant2" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// URL of Document for upload
        /// </param>
        /// <param name="title">
        /// Title to display
        /// </param>
        /// <param name="webhook">
        /// Callback to call when the document is uploaded
        /// </param>
        public CreateDocumentDtoVariant2(
            string sourceUrl,
            string title,
            string? webhook)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentDtoVariant2" /> class.
        /// </summary>
        public CreateDocumentDtoVariant2()
        {
        }
    }
}