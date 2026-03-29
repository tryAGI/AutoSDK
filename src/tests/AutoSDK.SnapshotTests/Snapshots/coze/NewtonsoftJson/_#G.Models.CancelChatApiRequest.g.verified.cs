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
        [global::Newtonsoft.Json.JsonProperty("chat_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChatId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelChatApiRequest" /> class.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="conversationId"></param>
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