//HintName: G.Models.ProtectedBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch protections protect branches
    /// </summary>
    public sealed partial class ProtectedBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Status Check Policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks")]
        public StatusCheckPolicy? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_pull_request_reviews")]
        public ProtectedBranchRequiredPullRequestReviews? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_signatures")]
        public ProtectedBranchRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_admins")]
        public ProtectedBranchEnforceAdmins? EnforceAdmins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_linear_history")]
        public ProtectedBranchRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes")]
        public ProtectedBranchAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions")]
        public ProtectedBranchAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution")]
        public ProtectedBranchRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_creations")]
        public ProtectedBranchBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch")]
        public ProtectedBranchLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_fork_syncing")]
        public ProtectedBranchAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}