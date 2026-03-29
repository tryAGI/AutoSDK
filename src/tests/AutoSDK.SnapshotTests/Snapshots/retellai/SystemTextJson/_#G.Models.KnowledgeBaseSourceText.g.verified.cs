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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceTextTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceTextType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Title of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// URL of the text content stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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