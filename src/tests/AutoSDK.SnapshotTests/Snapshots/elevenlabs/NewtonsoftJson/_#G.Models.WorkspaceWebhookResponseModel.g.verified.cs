//HintName: G.Models.WorkspaceWebhookResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceWebhookResponseModel
    {
        /// <summary>
        /// The display name for this webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The unique ID for this webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookId { get; set; } = default!;

        /// <summary>
        /// The HTTPS callback URL that is called when this webhook is triggered in the platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// Whether the webhook has been manually disabled by a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDisabled { get; set; } = default!;

        /// <summary>
        /// Whether the webhook has been automatically disabled due to repeated consecutive failures over a long period of time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_auto_disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAutoDisabled { get; set; } = default!;

        /// <summary>
        /// Original creation time of the webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookAuthMethodType AuthType { get; set; } = default!;

        /// <summary>
        /// The list of products that are currently configured to trigger this webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceWebhookUsageResponseModel>? Usage { get; set; }

        /// <summary>
        /// The most recent error code returned from the callback URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_failure_error_code")]
        public int? MostRecentFailureErrorCode { get; set; }

        /// <summary>
        /// The most recent time the webhook failed, failures are any non-200 codes returned by the callback URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_failure_timestamp")]
        public int? MostRecentFailureTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name for this webhook.
        /// </param>
        /// <param name="webhookId">
        /// The unique ID for this webhook.
        /// </param>
        /// <param name="webhookUrl">
        /// The HTTPS callback URL that is called when this webhook is triggered in the platform.
        /// </param>
        /// <param name="isDisabled">
        /// Whether the webhook has been manually disabled by a user.
        /// </param>
        /// <param name="isAutoDisabled">
        /// Whether the webhook has been automatically disabled due to repeated consecutive failures over a long period of time.
        /// </param>
        /// <param name="createdAtUnix">
        /// Original creation time of the webhook.
        /// </param>
        /// <param name="authType"></param>
        /// <param name="usage">
        /// The list of products that are currently configured to trigger this webhook.
        /// </param>
        /// <param name="mostRecentFailureErrorCode">
        /// The most recent error code returned from the callback URL.
        /// </param>
        /// <param name="mostRecentFailureTimestamp">
        /// The most recent time the webhook failed, failures are any non-200 codes returned by the callback URL.
        /// </param>
        public WorkspaceWebhookResponseModel(
            string name,
            string webhookId,
            string webhookUrl,
            bool isDisabled,
            bool isAutoDisabled,
            int createdAtUnix,
            global::G.WebhookAuthMethodType authType,
            global::System.Collections.Generic.IList<global::G.WorkspaceWebhookUsageResponseModel>? usage,
            int? mostRecentFailureErrorCode,
            int? mostRecentFailureTimestamp)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.IsDisabled = isDisabled;
            this.IsAutoDisabled = isAutoDisabled;
            this.CreatedAtUnix = createdAtUnix;
            this.AuthType = authType;
            this.Usage = usage;
            this.MostRecentFailureErrorCode = mostRecentFailureErrorCode;
            this.MostRecentFailureTimestamp = mostRecentFailureTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookResponseModel" /> class.
        /// </summary>
        public WorkspaceWebhookResponseModel()
        {
        }
    }
}