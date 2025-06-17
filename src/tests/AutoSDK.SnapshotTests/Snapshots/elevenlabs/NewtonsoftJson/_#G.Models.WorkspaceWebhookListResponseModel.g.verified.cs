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
        [global::Newtonsoft.Json.JsonProperty("webhooks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkspaceWebhookResponseModel> Webhooks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookListResponseModel" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// List of webhooks currently configured for the workspace
        /// </param>
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