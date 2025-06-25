//HintName: G.Models.WebhookBranchProtectionRuleEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If the action was `edited`, the changes to the rule.
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_enforced")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAdminEnforced? AdminEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actor_names")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? AuthorizedActorNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actors_only")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? AuthorizedActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_dismissal_actors_only")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? AuthorizedDismissalActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_history_requirement_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? LinearHistoryRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel? LockBranchEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_allows_fork_sync")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync? LockAllowsForkSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_reviews_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel? PullRequestReviewsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequireLastPushApproval? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? RequiredStatusChecksEnforcementLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChanges" /> class.
        /// </summary>
        /// <param name="adminEnforced"></param>
        /// <param name="authorizedActorNames"></param>
        /// <param name="authorizedActorsOnly"></param>
        /// <param name="authorizedDismissalActorsOnly"></param>
        /// <param name="linearHistoryRequirementEnforcementLevel"></param>
        /// <param name="lockBranchEnforcementLevel"></param>
        /// <param name="lockAllowsForkSync"></param>
        /// <param name="pullRequestReviewsEnforcementLevel"></param>
        /// <param name="requireLastPushApproval"></param>
        /// <param name="requiredStatusChecks"></param>
        /// <param name="requiredStatusChecksEnforcementLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBranchProtectionRuleEditedChanges(
            global::G.WebhookBranchProtectionRuleEditedChangesAdminEnforced? adminEnforced,
            global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? authorizedActorNames,
            global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? authorizedActorsOnly,
            global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? authorizedDismissalActorsOnly,
            global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? linearHistoryRequirementEnforcementLevel,
            global::G.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel? lockBranchEnforcementLevel,
            global::G.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync? lockAllowsForkSync,
            global::G.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel? pullRequestReviewsEnforcementLevel,
            global::G.WebhookBranchProtectionRuleEditedChangesRequireLastPushApproval? requireLastPushApproval,
            global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? requiredStatusChecks,
            global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? requiredStatusChecksEnforcementLevel)
        {
            this.AdminEnforced = adminEnforced;
            this.AuthorizedActorNames = authorizedActorNames;
            this.AuthorizedActorsOnly = authorizedActorsOnly;
            this.AuthorizedDismissalActorsOnly = authorizedDismissalActorsOnly;
            this.LinearHistoryRequirementEnforcementLevel = linearHistoryRequirementEnforcementLevel;
            this.LockBranchEnforcementLevel = lockBranchEnforcementLevel;
            this.LockAllowsForkSync = lockAllowsForkSync;
            this.PullRequestReviewsEnforcementLevel = pullRequestReviewsEnforcementLevel;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.RequiredStatusChecks = requiredStatusChecks;
            this.RequiredStatusChecksEnforcementLevel = requiredStatusChecksEnforcementLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChanges" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChanges()
        {
        }
    }
}