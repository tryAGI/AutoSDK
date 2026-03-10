//HintName: G.Models.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch
    {
        /// <summary>
        /// Whether to disable or enable the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDisabled { get; set; } = default!;

        /// <summary>
        /// The display name of the webhook (used for display purposes only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether to enable automatic retries for transient failures (5xx, 429, timeout)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_enabled")]
        public bool? RetryEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch" /> class.
        /// </summary>
        /// <param name="isDisabled">
        /// Whether to disable or enable the webhook
        /// </param>
        /// <param name="name">
        /// The display name of the webhook (used for display purposes only).
        /// </param>
        /// <param name="retryEnabled">
        /// Whether to enable automatic retries for transient failures (5xx, 429, timeout)
        /// </param>
        public BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch(
            bool isDisabled,
            string name,
            bool? retryEnabled)
        {
            this.IsDisabled = isDisabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RetryEnabled = retryEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch" /> class.
        /// </summary>
        public BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch()
        {
        }
    }
}