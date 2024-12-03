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
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workflow_permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActionsDefaultWorkflowPermissionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsDefaultWorkflowPermissions DefaultWorkflowPermissions { get; set; }

        /// <summary>
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_approve_pull_request_reviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanApprovePullRequestReviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetDefaultWorkflowPermissions" /> class.
        /// </summary>
        /// <param name="defaultWorkflowPermissions">
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </param>
        /// <param name="canApprovePullRequestReviews">
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsGetDefaultWorkflowPermissions(
            global::G.ActionsDefaultWorkflowPermissions defaultWorkflowPermissions,
            bool canApprovePullRequestReviews)
        {
            this.DefaultWorkflowPermissions = defaultWorkflowPermissions;
            this.CanApprovePullRequestReviews = canApprovePullRequestReviews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetDefaultWorkflowPermissions" /> class.
        /// </summary>
        public ActionsGetDefaultWorkflowPermissions()
        {
        }
    }
}