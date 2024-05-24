//HintName: G.Models.ActionsGetDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetDefaultWorkflowPermissions
    {
        /// <summary>
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_workflow_permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions DefaultWorkflowPermissions { get; set; } = default!;

        /// <summary>
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_approve_pull_request_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanApprovePullRequestReviews { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}