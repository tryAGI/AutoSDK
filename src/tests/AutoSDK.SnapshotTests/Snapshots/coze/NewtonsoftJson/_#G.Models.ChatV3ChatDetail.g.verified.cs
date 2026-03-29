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
        [global::Newtonsoft.Json.JsonProperty("bot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error")]
        public global::G.LastError? LastError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_action")]
        public global::G.RequiredAction? RequiredAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("section_id")]
        public string? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage2? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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