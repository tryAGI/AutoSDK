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
        public global::G.WebhooksRuleAllowDeletionsEnforcementLevel AllowDeletionsEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleAllowForcePushesEnforcementLevel AllowForcePushesEnforcementLevel { get; set; } = default!;

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
        public bool? CreateProtected { get; set; }

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
        public global::G.WebhooksRuleLinearHistoryRequirementEnforcementLevel LinearHistoryRequirementEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// The enforcement level of the branch lock setting. `off` means the branch is not locked, `non_admins` means the branch is read-only for non_admins, and `everyone` means the branch is read-only for everyone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleLockBranchEnforcementLevel LockBranchEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow users to pull changes from upstream when the branch is locked. This setting is only applicable for forks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_allows_fork_sync")]
        public bool? LockAllowsForkSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_queue_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleMergeQueueEnforcementLevel MergeQueueEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_reviews_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRulePullRequestReviewsEnforcementLevel PullRequestReviewsEnforcementLevel { get; set; } = default!;

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
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequiredApprovingReviewCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleRequiredConversationResolutionLevel RequiredConversationResolutionLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_deployments_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleRequiredDeploymentsEnforcementLevel RequiredDeploymentsEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RequiredStatusChecks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel RequiredStatusChecksEnforcementLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature_requirement_enforcement_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRuleSignatureRequirementEnforcementLevel SignatureRequirementEnforcementLevel { get; set; } = default!;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRule" /> class.
        /// </summary>
        /// <param name="adminEnforced"></param>
        /// <param name="allowDeletionsEnforcementLevel"></param>
        /// <param name="allowForcePushesEnforcementLevel"></param>
        /// <param name="authorizedActorNames"></param>
        /// <param name="authorizedActorsOnly"></param>
        /// <param name="authorizedDismissalActorsOnly"></param>
        /// <param name="createProtected"></param>
        /// <param name="createdAt"></param>
        /// <param name="dismissStaleReviewsOnPush"></param>
        /// <param name="id"></param>
        /// <param name="ignoreApprovalsFromContributors"></param>
        /// <param name="linearHistoryRequirementEnforcementLevel"></param>
        /// <param name="lockBranchEnforcementLevel">
        /// The enforcement level of the branch lock setting. `off` means the branch is not locked, `non_admins` means the branch is read-only for non_admins, and `everyone` means the branch is read-only for everyone.
        /// </param>
        /// <param name="lockAllowsForkSync">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow users to pull changes from upstream when the branch is locked. This setting is only applicable for forks.
        /// </param>
        /// <param name="mergeQueueEnforcementLevel"></param>
        /// <param name="name"></param>
        /// <param name="pullRequestReviewsEnforcementLevel"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requireCodeOwnerReview"></param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it
        /// </param>
        /// <param name="requiredApprovingReviewCount"></param>
        /// <param name="requiredConversationResolutionLevel"></param>
        /// <param name="requiredDeploymentsEnforcementLevel"></param>
        /// <param name="requiredStatusChecks"></param>
        /// <param name="requiredStatusChecksEnforcementLevel"></param>
        /// <param name="signatureRequirementEnforcementLevel"></param>
        /// <param name="strictRequiredStatusChecksPolicy"></param>
        /// <param name="updatedAt"></param>
        public WebhooksRule(
            bool adminEnforced,
            global::G.WebhooksRuleAllowDeletionsEnforcementLevel allowDeletionsEnforcementLevel,
            global::G.WebhooksRuleAllowForcePushesEnforcementLevel allowForcePushesEnforcementLevel,
            global::System.Collections.Generic.IList<string> authorizedActorNames,
            bool authorizedActorsOnly,
            bool authorizedDismissalActorsOnly,
            global::System.DateTime createdAt,
            bool dismissStaleReviewsOnPush,
            int id,
            bool ignoreApprovalsFromContributors,
            global::G.WebhooksRuleLinearHistoryRequirementEnforcementLevel linearHistoryRequirementEnforcementLevel,
            global::G.WebhooksRuleLockBranchEnforcementLevel lockBranchEnforcementLevel,
            global::G.WebhooksRuleMergeQueueEnforcementLevel mergeQueueEnforcementLevel,
            string name,
            global::G.WebhooksRulePullRequestReviewsEnforcementLevel pullRequestReviewsEnforcementLevel,
            int repositoryId,
            bool requireCodeOwnerReview,
            int requiredApprovingReviewCount,
            global::G.WebhooksRuleRequiredConversationResolutionLevel requiredConversationResolutionLevel,
            global::G.WebhooksRuleRequiredDeploymentsEnforcementLevel requiredDeploymentsEnforcementLevel,
            global::System.Collections.Generic.IList<string> requiredStatusChecks,
            global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel requiredStatusChecksEnforcementLevel,
            global::G.WebhooksRuleSignatureRequirementEnforcementLevel signatureRequirementEnforcementLevel,
            bool strictRequiredStatusChecksPolicy,
            global::System.DateTime updatedAt,
            bool? createProtected,
            bool? lockAllowsForkSync,
            bool? requireLastPushApproval)
        {
            this.AdminEnforced = adminEnforced;
            this.AllowDeletionsEnforcementLevel = allowDeletionsEnforcementLevel;
            this.AllowForcePushesEnforcementLevel = allowForcePushesEnforcementLevel;
            this.AuthorizedActorNames = authorizedActorNames ?? throw new global::System.ArgumentNullException(nameof(authorizedActorNames));
            this.AuthorizedActorsOnly = authorizedActorsOnly;
            this.AuthorizedDismissalActorsOnly = authorizedDismissalActorsOnly;
            this.CreatedAt = createdAt;
            this.DismissStaleReviewsOnPush = dismissStaleReviewsOnPush;
            this.Id = id;
            this.IgnoreApprovalsFromContributors = ignoreApprovalsFromContributors;
            this.LinearHistoryRequirementEnforcementLevel = linearHistoryRequirementEnforcementLevel;
            this.LockBranchEnforcementLevel = lockBranchEnforcementLevel;
            this.MergeQueueEnforcementLevel = mergeQueueEnforcementLevel;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PullRequestReviewsEnforcementLevel = pullRequestReviewsEnforcementLevel;
            this.RepositoryId = repositoryId;
            this.RequireCodeOwnerReview = requireCodeOwnerReview;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequiredConversationResolutionLevel = requiredConversationResolutionLevel;
            this.RequiredDeploymentsEnforcementLevel = requiredDeploymentsEnforcementLevel;
            this.RequiredStatusChecks = requiredStatusChecks ?? throw new global::System.ArgumentNullException(nameof(requiredStatusChecks));
            this.RequiredStatusChecksEnforcementLevel = requiredStatusChecksEnforcementLevel;
            this.SignatureRequirementEnforcementLevel = signatureRequirementEnforcementLevel;
            this.StrictRequiredStatusChecksPolicy = strictRequiredStatusChecksPolicy;
            this.UpdatedAt = updatedAt;
            this.CreateProtected = createProtected;
            this.LockAllowsForkSync = lockAllowsForkSync;
            this.RequireLastPushApproval = requireLastPushApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRule" /> class.
        /// </summary>
        public WebhooksRule()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhooksRule? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhooksRule>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhooksRule?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhooksRule?>(serializer.Deserialize<global::G.WebhooksRule>(jsonReader));
        }

    }
}