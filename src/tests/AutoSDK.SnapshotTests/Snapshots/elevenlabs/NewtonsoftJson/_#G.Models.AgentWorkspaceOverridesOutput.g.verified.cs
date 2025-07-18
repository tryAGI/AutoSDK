﻿//HintName: G.Models.AgentWorkspaceOverridesOutput.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("conversation_initiation_client_data_webhook")]
        public global::G.ConversationInitiationClientDataWebhook? ConversationInitiationClientDataWebhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::G.ConvAIWebhooks? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesOutput" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        public AgentWorkspaceOverridesOutput(
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::G.ConvAIWebhooks? webhooks)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkspaceOverridesOutput" /> class.
        /// </summary>
        public AgentWorkspaceOverridesOutput()
        {
        }
    }
}