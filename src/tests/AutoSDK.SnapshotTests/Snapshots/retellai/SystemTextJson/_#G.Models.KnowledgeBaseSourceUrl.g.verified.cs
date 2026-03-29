//HintName: G.Models.KnowledgeBaseSourceUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseSourceUrl
    {
        /// <summary>
        /// Type of the knowledge base source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceUrlTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceUrlType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// URL used to be scraped and added to the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceUrl" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Unique id of the knowledge base source.
        /// </param>
        /// <param name="url">
        /// URL used to be scraped and added to the knowledge base.
        /// </param>
        /// <param name="type">
        /// Type of the knowledge base source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseSourceUrl(
            string sourceId,
            string url,
            global::G.KnowledgeBaseSourceUrlType type)
        {
            this.Type = type;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceUrl" /> class.
        /// </summary>
        public KnowledgeBaseSourceUrl()
        {
        }
    }
}