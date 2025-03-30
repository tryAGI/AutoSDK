//HintName: G.Models.AgentWorkspaceOverridesOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentWorkspaceOverridesOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data_webhook")]
        public global::G.ConversationInitiationClientDataWebhook? ConversationInitiationClientDataWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesOutput" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWorkspaceOverridesOutput(
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesOutput" /> class.
        /// </summary>
        public AgentWorkspaceOverridesOutput()
        {
        }
    }
}