//HintName: G.Models.OpenMessageApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenMessageApi
    {
        /// <summary>
        /// bot id //已TODO 所有的i64加注解str,入参和出参都要
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenMessageApiContentTypeJsonConverter))]
        public global::G.OpenMessageApiContentType? ContentType { get; set; }

        /// <summary>
        /// conversation id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenMessageApiRoleJsonConverter))]
        public global::G.OpenMessageApiRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        public string? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenMessageApiTypeJsonConverter))]
        public global::G.OpenMessageApiType? Type { get; set; }

        /// <summary>
        /// 更新时间 //已TODO 时间改成int
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenMessageApi" /> class.
        /// </summary>
        /// <param name="botId">
        /// bot id //已TODO 所有的i64加注解str,入参和出参都要
        /// </param>
        /// <param name="chatId"></param>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="conversationId">
        /// conversation id
        /// </param>
        /// <param name="createdAt">
        /// 创建时间
        /// </param>
        /// <param name="id">
        /// 主键ID
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="role"></param>
        /// <param name="sectionId"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt">
        /// 更新时间 //已TODO 时间改成int
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenMessageApi(
            string? botId,
            string? chatId,
            string? content,
            global::G.OpenMessageApiContentType? contentType,
            string? conversationId,
            int? createdAt,
            string? id,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            string? reasoningContent,
            global::G.OpenMessageApiRole? role,
            string? sectionId,
            global::G.OpenMessageApiType? type,
            int? updatedAt)
        {
            this.BotId = botId;
            this.ChatId = chatId;
            this.Content = content;
            this.ContentType = contentType;
            this.ConversationId = conversationId;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.MetaData = metaData;
            this.ReasoningContent = reasoningContent;
            this.Role = role;
            this.SectionId = sectionId;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenMessageApi" /> class.
        /// </summary>
        public OpenMessageApi()
        {
        }
    }
}