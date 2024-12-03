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
        [global::Newtonsoft.Json.JsonProperty("default_workflow_permissions")]
        public global::G.ActionsDefaultWorkflowPermissions? DefaultWorkflowPermissions { get; set; }

        /// <summary>
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_approve_pull_request_reviews")]
        public bool? CanApprovePullRequestReviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetDefaultWorkflowPermissions" /> class.
        /// </summary>
        /// <param name="defaultWorkflowPermissions">
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </param>
        /// <param name="canApprovePullRequestReviews">
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </param>
        public ActionsSetDefaultWorkflowPermissions(
            global::G.ActionsDefaultWorkflowPermissions? defaultWorkflowPermissions,
            bool? canApprovePullRequestReviews)
        {
            this.DefaultWorkflowPermissions = defaultWorkflowPermissions;
            this.CanApprovePullRequestReviews = canApprovePullRequestReviews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetDefaultWorkflowPermissions" /> class.
        /// </summary>
        public ActionsSetDefaultWorkflowPermissions()
        {
        }
    }
}