//HintName: G.Models.WorkspaceWebhookUsageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceWebhookUsageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookUsageType UsageType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookUsageResponseModel" /> class.
        /// </summary>
        /// <param name="usageType"></param>
        public WorkspaceWebhookUsageResponseModel(
            global::G.WebhookUsageType usageType)
        {
            this.UsageType = usageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookUsageResponseModel" /> class.
        /// </summary>
        public WorkspaceWebhookUsageResponseModel()
        {
        }
    }
}