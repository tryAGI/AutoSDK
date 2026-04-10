//HintName: G.Models.ILogicalChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ILogicalChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IMessage> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_mode")]
        public string? ChatMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_count")]
        public double? MessageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persist_messages")]
        public bool? PersistMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ILogicalChatPlanJsonConverter))]
        public global::G.ILogicalChatPlan Plan { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_minutes")]
        public double? DurationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details_url")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.ILogicalChatAgent? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insights")]
        public global::G.ILogicalChatInsights? Insights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("livekit_session_id")]
        public string? LivekitSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ILogicalChat" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="externalId"></param>
        /// <param name="plan"></param>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="origin"></param>
        /// <param name="chatMode"></param>
        /// <param name="messageCount"></param>
        /// <param name="persistMessages"></param>
        /// <param name="durationMinutes"></param>
        /// <param name="detailsUrl"></param>
        /// <param name="agent"></param>
        /// <param name="insights"></param>
        /// <param name="region"></param>
        /// <param name="livekitSessionId"></param>
        public ILogicalChat(
            global::System.Collections.Generic.IList<global::G.IMessage> messages,
            string agentId,
            string externalId,
            global::G.ILogicalChatPlan plan,
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            string? origin,
            string? chatMode,
            double? messageCount,
            bool? persistMessages,
            double? durationMinutes,
            string? detailsUrl,
            global::G.ILogicalChatAgent? agent,
            global::G.ILogicalChatInsights? insights,
            string? region,
            string? livekitSessionId)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Origin = origin;
            this.ChatMode = chatMode;
            this.MessageCount = messageCount;
            this.PersistMessages = persistMessages;
            this.Plan = plan;
            this.DurationMinutes = durationMinutes;
            this.DetailsUrl = detailsUrl;
            this.Agent = agent;
            this.Insights = insights;
            this.Region = region;
            this.LivekitSessionId = livekitSessionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ILogicalChat" /> class.
        /// </summary>
        public ILogicalChat()
        {
        }
    }
}