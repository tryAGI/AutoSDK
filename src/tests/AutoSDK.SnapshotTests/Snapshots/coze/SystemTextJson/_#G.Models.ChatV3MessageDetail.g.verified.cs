//HintName: G.Models.ChatV3MessageDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatV3MessageDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        public string? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3MessageDetail" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="chatId"></param>
        /// <param name="content"></param>
        /// <param name="contentType"></param>
        /// <param name="conversationId"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="metaData"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="sectionId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatV3MessageDetail(
            string botId,
            string chatId,
            string content,
            string contentType,
            string conversationId,
            string id,
            string role,
            string type,
            int? createdAt,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            string? reasoningContent,
            string? sectionId,
            int? updatedAt)
        {
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MetaData = metaData;
            this.ReasoningContent = reasoningContent;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.SectionId = sectionId;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3MessageDetail" /> class.
        /// </summary>
        public ChatV3MessageDetail()
        {
        }
    }
}