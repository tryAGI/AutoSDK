//HintName: G.Models.WorkspaceWebhookListResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceWebhookListResponseModel
    {
        /// <summary>
        /// List of webhooks currently configured for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WorkspaceWebhookResponseModel> Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookListResponseModel" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// List of webhooks currently configured for the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceWebhookListResponseModel(
            global::System.Collections.Generic.IList<global::G.WorkspaceWebhookResponseModel> webhooks)
        {
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookListResponseModel" /> class.
        /// </summary>
        public WorkspaceWebhookListResponseModel()
        {
        }
    }
}