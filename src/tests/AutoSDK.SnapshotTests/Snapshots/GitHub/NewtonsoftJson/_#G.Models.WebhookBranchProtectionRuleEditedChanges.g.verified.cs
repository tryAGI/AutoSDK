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
        [global::Newtonsoft.Json.JsonProperty("admin_enforced")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAdminEnforced? AdminEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_actor_names")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? AuthorizedActorNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_actors_only")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? AuthorizedActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorized_dismissal_actors_only")]
        public global::G.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? AuthorizedDismissalActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linear_history_requirement_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? LinearHistoryRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel? LockBranchEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_allows_fork_sync")]
        public global::G.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync? LockAllowsForkSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_reviews_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel? PullRequestReviewsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequireLastPushApproval? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks_enforcement_level")]
        public global::G.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? RequiredStatusChecksEnforcementLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.WebhookBranchProtectionRuleEditedChanges? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookBranchProtectionRuleEditedChanges>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookBranchProtectionRuleEditedChanges?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookBranchProtectionRuleEditedChanges?>(serializer.Deserialize<global::G.WebhookBranchProtectionRuleEditedChanges>(jsonReader));
        }

    }
}