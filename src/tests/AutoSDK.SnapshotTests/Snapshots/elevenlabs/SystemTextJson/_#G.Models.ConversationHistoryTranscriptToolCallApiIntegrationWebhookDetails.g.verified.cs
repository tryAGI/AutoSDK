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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationHistoryTranscriptToolCallWebhookDetails WebhookDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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