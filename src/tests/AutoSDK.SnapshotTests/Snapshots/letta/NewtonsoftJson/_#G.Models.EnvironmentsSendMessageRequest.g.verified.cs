//HintName: G.Models.EnvironmentsSendMessageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2>> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        public EnvironmentsSendMessageRequest(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2>> messages,
            string? agentId,
            string? conversationId)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.AgentId = agentId;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequest" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequest()
        {
        }
    }
}