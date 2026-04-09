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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceUrlTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceUrlType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// URL used to be scraped and added to the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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