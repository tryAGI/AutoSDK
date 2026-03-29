//HintName: G.Models.ChatResponseMatche2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponseMatche2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponseMatche2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="title"></param>
        /// <param name="documentId"></param>
        /// <param name="knowledgeId"></param>
        /// <param name="sourceUrl"></param>
        public ChatResponseMatche2(
            string id,
            string data,
            string title,
            string documentId,
            string knowledgeId,
            string sourceUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.KnowledgeId = knowledgeId ?? throw new global::System.ArgumentNullException(nameof(knowledgeId));
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponseMatche2" /> class.
        /// </summary>
        public ChatResponseMatche2()
        {
        }
    }
}