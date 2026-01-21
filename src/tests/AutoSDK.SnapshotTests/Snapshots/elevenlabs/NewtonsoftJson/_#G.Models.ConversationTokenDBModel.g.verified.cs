//HintName: G.Models.ConversationTokenDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent_id":"agent_J3Pbu5gP6NNKBscdCdwB","conversation_id":"conv_J3Pbu5gP6NNKBscdCdwB","conversation_token":"1234567890","expiration_time_unix_secs":1716153600,"purpose":"signed_url"}
    /// </summary>
    public sealed partial class ConversationTokenDBModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The token for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationToken { get; set; } = default!;

        /// <summary>
        /// The expiration time of the token in unix seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiration_time_unix_secs")]
        public int? ExpirationTimeUnixSecs { get; set; }

        /// <summary>
        /// The ID of the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The purpose of the token<br/>
        /// Default Value: signed_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public global::G.ConversationTokenPurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="conversationId">
        /// The ID of the conversation
        /// </param>
        /// <param name="purpose">
        /// The purpose of the token<br/>
        /// Default Value: signed_url
        /// </param>
        public ConversationTokenDBModel(
            string agentId,
            string conversationToken,
            int? expirationTimeUnixSecs,
            string? conversationId,
            global::G.ConversationTokenPurpose? purpose)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationToken = conversationToken ?? throw new global::System.ArgumentNullException(nameof(conversationToken));
            this.ExpirationTimeUnixSecs = expirationTimeUnixSecs;
            this.ConversationId = conversationId;
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