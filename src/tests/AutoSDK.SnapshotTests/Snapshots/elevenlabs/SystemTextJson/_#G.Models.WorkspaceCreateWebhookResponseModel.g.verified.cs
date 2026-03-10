//HintName: G.Models.WorkspaceCreateWebhookResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceCreateWebhookResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateWebhookResponseModel" /> class.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreateWebhookResponseModel(
            string webhookId,
            string? webhookSecret)
        {
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateWebhookResponseModel" /> class.
        /// </summary>
        public WorkspaceCreateWebhookResponseModel()
        {
        }
    }
}