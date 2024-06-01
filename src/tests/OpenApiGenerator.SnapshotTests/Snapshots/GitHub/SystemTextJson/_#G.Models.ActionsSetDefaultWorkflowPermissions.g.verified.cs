//HintName: G.Models.ActionsSetDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetDefaultWorkflowPermissions
    {
        /// <summary>
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workflow_permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissionsJsonConverter))]
        public ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions? DefaultWorkflowPermissions { get; set; }

        /// <summary>
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_approve_pull_request_reviews")]
        public bool CanApprovePullRequestReviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}