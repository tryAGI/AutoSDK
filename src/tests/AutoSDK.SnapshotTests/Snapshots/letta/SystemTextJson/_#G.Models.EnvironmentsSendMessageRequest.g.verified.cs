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
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2>> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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