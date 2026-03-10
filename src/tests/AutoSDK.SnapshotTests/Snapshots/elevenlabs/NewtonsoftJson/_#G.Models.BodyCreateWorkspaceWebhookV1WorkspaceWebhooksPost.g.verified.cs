//HintName: G.Models.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost
    {
        /// <summary>
        /// Webhook settings object containing auth_type and corresponding configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookHMACSettings Settings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost" /> class.
        /// </summary>
        /// <param name="settings">
        /// Webhook settings object containing auth_type and corresponding configuration
        /// </param>
        public BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost(
            global::G.WebhookHMACSettings settings)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost" /> class.
        /// </summary>
        public BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost()
        {
        }
    }
}