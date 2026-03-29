//HintName: G.Models.CancelChatApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelChatApiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelChatApiRequest" /> class.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelChatApiRequest(
            string chatId,
            string conversationId)
        {
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelChatApiRequest" /> class.
        /// </summary>
        public CancelChatApiRequest()
        {
        }
    }
}