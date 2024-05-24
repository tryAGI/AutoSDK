//HintName: G.Models.BranchProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch Protection
    /// </summary>
    public sealed partial class BranchProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Protected Branch Required Status Check
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks")]
        public ProtectedBranchRequiredStatusCheck? RequiredStatusChecks { get; set; }

        /// <summary>
        /// Protected Branch Admin Enforced
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_admins")]
        public ProtectedBranchAdminEnforced? EnforceAdmins { get; set; }

        /// <summary>
        /// Protected Branch Pull Request Review
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_pull_request_reviews")]
        public ProtectedBranchPullRequestReview? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_linear_history")]
        public BranchProtectionRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes")]
        public BranchProtectionAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions")]
        public BranchProtectionAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_creations")]
        public BranchProtectionBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution")]
        public BranchProtectionRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// <br/>Example: "branch/with/protection"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_signatures")]
        public BranchProtectionRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch")]
        public BranchProtectionLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_fork_syncing")]
        public BranchProtectionAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}