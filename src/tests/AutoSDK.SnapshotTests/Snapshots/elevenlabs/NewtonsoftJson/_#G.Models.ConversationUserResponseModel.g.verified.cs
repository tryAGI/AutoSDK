//HintName: G.Models.ConversationUserResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationUserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_contact_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastContactUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_contact_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int FirstContactUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ConversationCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_contact_agent_id")]
        public string? LastContactAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_contact_conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastContactConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_contact_agent_name")]
        public string? LastContactAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserResponseModel" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lastContactUnixSecs"></param>
        /// <param name="firstContactUnixSecs"></param>
        /// <param name="conversationCount"></param>
        /// <param name="lastContactConversationId"></param>
        /// <param name="lastContactAgentId"></param>
        /// <param name="lastContactAgentName"></param>
        public ConversationUserResponseModel(
            string userId,
            int lastContactUnixSecs,
            int firstContactUnixSecs,
            int conversationCount,
            string lastContactConversationId,
            string? lastContactAgentId,
            string? lastContactAgentName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.LastContactUnixSecs = lastContactUnixSecs;
            this.FirstContactUnixSecs = firstContactUnixSecs;
            this.ConversationCount = conversationCount;
            this.LastContactAgentId = lastContactAgentId;
            this.LastContactConversationId = lastContactConversationId ?? throw new global::System.ArgumentNullException(nameof(lastContactConversationId));
            this.LastContactAgentName = lastContactAgentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserResponseModel" /> class.
        /// </summary>
        public ConversationUserResponseModel()
        {
        }
    }
}