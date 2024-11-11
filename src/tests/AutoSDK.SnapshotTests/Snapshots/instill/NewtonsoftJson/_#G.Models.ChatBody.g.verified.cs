//HintName: G.Models.ChatBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ChatRequest represents a request to send a message<br/>
    /// to a chatbot synchronously and streams back the results.
    /// </summary>
    public sealed partial class ChatBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CatalogId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversationUid", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationUid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBody" /> class.
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="conversationUid"></param>
        /// <param name="message"></param>
        /// <param name="topK"></param>
        public ChatBody(
            string catalogId,
            string conversationUid,
            string message,
            long? topK)
        {
            this.CatalogId = catalogId ?? throw new global::System.ArgumentNullException(nameof(catalogId));
            this.ConversationUid = conversationUid ?? throw new global::System.ArgumentNullException(nameof(conversationUid));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBody" /> class.
        /// </summary>
        public ChatBody()
        {
        }
    }
}