//HintName: G.Models.AgentWorkspaceOverridesInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentWorkspaceOverridesInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_initiation_client_data_webhook")]
        public global::G.ConversationInitiationClientDataWebhook? ConversationInitiationClientDataWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesInput" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        public AgentWorkspaceOverridesInput(
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesInput" /> class.
        /// </summary>
        public AgentWorkspaceOverridesInput()
        {
        }
    }
}