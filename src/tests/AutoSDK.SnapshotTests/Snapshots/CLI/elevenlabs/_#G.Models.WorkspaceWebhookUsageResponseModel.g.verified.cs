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
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookUsageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookUsageType UsageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWebhookUsageResponseModel" /> class.
        /// </summary>
        /// <param name="usageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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