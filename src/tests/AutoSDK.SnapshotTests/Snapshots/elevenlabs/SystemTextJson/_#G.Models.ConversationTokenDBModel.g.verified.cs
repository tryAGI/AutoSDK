//HintName: G.Models.ConversationTokenDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTokenDBModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The token for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationToken { get; set; }

        /// <summary>
        /// The expiration time of the token in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_time_unix_secs")]
        public int? ExpirationTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationTokenPurposeJsonConverter))]
        public global::G.ConversationTokenPurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenDBModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="conversationToken">
        /// The token for the agent
        /// </param>
        /// <param name="expirationTimeUnixSecs">
        /// The expiration time of the token in unix seconds
        /// </param>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTokenDBModel(
            string agentId,
            string conversationToken,
            int? expirationTimeUnixSecs,
            global::G.ConversationTokenPurpose? purpose)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationToken = conversationToken ?? throw new global::System.ArgumentNullException(nameof(conversationToken));
            this.ExpirationTimeUnixSecs = expirationTimeUnixSecs;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenDBModel" /> class.
        /// </summary>
        public ConversationTokenDBModel()
        {
        }
    }
}