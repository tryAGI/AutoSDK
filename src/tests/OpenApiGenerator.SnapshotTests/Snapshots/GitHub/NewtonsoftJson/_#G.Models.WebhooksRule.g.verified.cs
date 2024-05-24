//HintName: G.Models.WebhooksRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The branch protection rule. Includes a `name` and all the [branch protection settings](https://docs.github.com/github/administering-a-repository/defining-the-mergeability-of-pull-requests/about-protected-branches#about-branch-protection-settings) applied to branches that match the name. Binary settings are boolean. Multi-level configurations are one of `off`, `non_admins`, or `everyone`. Actor and build lists are arrays of strings.
    /// </summary>
    public sealed partial class WebhooksRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin_enforced", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AdminEnforced { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleAllowDeletionsEnforcementLevel AllowDeletionsEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleAllowForcePushesEnforcementLevel AllowForcePushesEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_actor_names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AuthorizedActorNames { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_actors_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AuthorizedActorsOnly { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_dismissal_actors_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AuthorizedDismissalActorsOnly { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_protected")]
        public bool CreateProtected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews_on_push", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DismissStaleReviewsOnPush { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_approvals_from_contributors", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IgnoreApprovalsFromContributors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linear_history_requirement_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleLinearHistoryRequirementEnforcementLevel LinearHistoryRequirementEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_queue_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleMergeQueueEnforcementLevel MergeQueueEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_reviews_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRulePullRequestReviewsEnforcementLevel PullRequestReviewsEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_review", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireCodeOwnerReview { get; set; } = default!;

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public bool RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequiredApprovingReviewCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleRequiredConversationResolutionLevel RequiredConversationResolutionLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_deployments_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleRequiredDeploymentsEnforcementLevel RequiredDeploymentsEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RequiredStatusChecks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleRequiredStatusChecksEnforcementLevel RequiredStatusChecksEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature_requirement_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhooksRuleSignatureRequirementEnforcementLevel SignatureRequirementEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict_required_status_checks_policy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StrictRequiredStatusChecksPolicy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}