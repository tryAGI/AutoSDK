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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastContactUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_contact_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FirstContactUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_agent_id")]
        public string? LastContactAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastContactConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_agent_name")]
        public string? LastContactAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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