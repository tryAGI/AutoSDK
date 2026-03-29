//HintName: G.Models.ChatV3ChatDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatV3ChatDetail
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
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public global::G.LastError? LastError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_action")]
        public global::G.RequiredAction? RequiredAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        public string? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.Usage2? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3ChatDetail" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="conversationId"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="failedAt"></param>
        /// <param name="lastError"></param>
        /// <param name="metaData"></param>
        /// <param name="requiredAction"></param>
        /// <param name="sectionId"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatV3ChatDetail(
            string botId,
            string conversationId,
            string id,
            string status,
            int? completedAt,
            int? createdAt,
            int? failedAt,
            global::G.LastError? lastError,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            global::G.RequiredAction? requiredAction,
            string? sectionId,
            global::G.Usage2? usage)
        {
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.CompletedAt = completedAt;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.CreatedAt = createdAt;
            this.FailedAt = failedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastError = lastError;
            this.MetaData = metaData;
            this.RequiredAction = requiredAction;
            this.SectionId = sectionId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3ChatDetail" /> class.
        /// </summary>
        public ChatV3ChatDetail()
        {
        }
    }
}