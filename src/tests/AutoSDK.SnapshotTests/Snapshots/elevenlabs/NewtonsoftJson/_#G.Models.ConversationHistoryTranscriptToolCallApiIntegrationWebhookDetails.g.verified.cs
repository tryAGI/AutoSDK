//HintName: G.Models.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails
    {
        /// <summary>
        /// Default Value: api_integration_webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CredentialId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_connection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationConnectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationHistoryTranscriptToolCallWebhookDetails WebhookDetails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="credentialId"></param>
        /// <param name="integrationConnectionId"></param>
        /// <param name="webhookDetails"></param>
        /// <param name="type">
        /// Default Value: api_integration_webhook
        /// </param>
        public ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails(
            string integrationId,
            string credentialId,
            string integrationConnectionId,
            global::G.ConversationHistoryTranscriptToolCallWebhookDetails webhookDetails,
            string? type)
        {
            this.Type = type;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.IntegrationConnectionId = integrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(integrationConnectionId));
            this.WebhookDetails = webhookDetails ?? throw new global::System.ArgumentNullException(nameof(webhookDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails()
        {
        }
    }
}