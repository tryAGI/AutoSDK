//HintName: G.Models.PatchConvAISettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConvAISettingsRequest
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
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_mcp_servers")]
        public bool? CanUseMcpServers { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_retention_period_days")]
        public int? RagRetentionPeriodDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAISettingsRequest" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="canUseMcpServers">
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
        public PatchConvAISettingsRequest(
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::G.ConvAIWebhooks? webhooks,
            bool? canUseMcpServers,
            int? ragRetentionPeriodDays)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
            this.Webhooks = webhooks;
            this.CanUseMcpServers = canUseMcpServers;
            this.RagRetentionPeriodDays = ragRetentionPeriodDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAISettingsRequest" /> class.
        /// </summary>
        public PatchConvAISettingsRequest()
        {
        }
    }
}