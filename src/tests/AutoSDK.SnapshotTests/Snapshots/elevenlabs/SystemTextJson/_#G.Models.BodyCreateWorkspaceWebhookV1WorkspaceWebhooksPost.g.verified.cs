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
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookHMACSettings Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost" /> class.
        /// </summary>
        /// <param name="settings">
        /// Webhook settings object containing auth_type and corresponding configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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