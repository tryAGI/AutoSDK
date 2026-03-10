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
        [global::Newtonsoft.Json.JsonProperty("webhook_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateWebhookResponseModel" /> class.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookSecret"></param>
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