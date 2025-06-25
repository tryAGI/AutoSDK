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
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBody" /> class.
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="conversationUid"></param>
        /// <param name="message"></param>
        /// <param name="topK"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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