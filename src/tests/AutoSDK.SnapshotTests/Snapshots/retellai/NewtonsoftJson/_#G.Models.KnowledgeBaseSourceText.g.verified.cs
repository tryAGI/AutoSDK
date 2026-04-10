//HintName: G.Models.KnowledgeBaseSourceText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseSourceText
    {
        /// <summary>
        /// Type of the knowledge base source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceTextTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceTextType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// Title of the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// URL of the text content stored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceText" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Unique id of the knowledge base source.
        /// </param>
        /// <param name="title">
        /// Title of the text.
        /// </param>
        /// <param name="contentUrl">
        /// URL of the text content stored.
        /// </param>
        /// <param name="type">
        /// Type of the knowledge base source.
        /// </param>
        public KnowledgeBaseSourceText(
            string sourceId,
            string title,
            string contentUrl,
            global::G.KnowledgeBaseSourceTextType type)
        {
            this.Type = type;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ContentUrl = contentUrl ?? throw new global::System.ArgumentNullException(nameof(contentUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceText" /> class.
        /// </summary>
        public KnowledgeBaseSourceText()
        {
        }
    }
}