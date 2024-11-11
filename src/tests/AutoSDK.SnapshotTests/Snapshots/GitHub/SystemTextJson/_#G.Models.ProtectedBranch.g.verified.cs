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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Status Check Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public global::G.StatusCheckPolicy? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_pull_request_reviews")]
        public global::G.ProtectedBranchRequiredPullRequestReviews? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_signatures")]
        public global::G.ProtectedBranchRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_admins")]
        public global::G.ProtectedBranchEnforceAdmins? EnforceAdmins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_linear_history")]
        public global::G.ProtectedBranchRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_force_pushes")]
        public global::G.ProtectedBranchAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_deletions")]
        public global::G.ProtectedBranchAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::G.BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_conversation_resolution")]
        public global::G.ProtectedBranchRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_creations")]
        public global::G.ProtectedBranchBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch")]
        public global::G.ProtectedBranchLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fork_syncing")]
        public global::G.ProtectedBranchAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranch" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requiredStatusChecks">
        /// Status Check Policy
        /// </param>
        /// <param name="requiredPullRequestReviews"></param>
        /// <param name="requiredSignatures"></param>
        /// <param name="enforceAdmins"></param>
        /// <param name="requiredLinearHistory"></param>
        /// <param name="allowForcePushes"></param>
        /// <param name="allowDeletions"></param>
        /// <param name="restrictions">
        /// Branch Restriction Policy
        /// </param>
        /// <param name="requiredConversationResolution"></param>
        /// <param name="blockCreations"></param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProtectedBranch(
            string url,
            global::G.StatusCheckPolicy? requiredStatusChecks,
            global::G.ProtectedBranchRequiredPullRequestReviews? requiredPullRequestReviews,
            global::G.ProtectedBranchRequiredSignatures? requiredSignatures,
            global::G.ProtectedBranchEnforceAdmins? enforceAdmins,
            global::G.ProtectedBranchRequiredLinearHistory? requiredLinearHistory,
            global::G.ProtectedBranchAllowForcePushes? allowForcePushes,
            global::G.ProtectedBranchAllowDeletions? allowDeletions,
            global::G.BranchRestrictionPolicy? restrictions,
            global::G.ProtectedBranchRequiredConversationResolution? requiredConversationResolution,
            global::G.ProtectedBranchBlockCreations? blockCreations,
            global::G.ProtectedBranchLockBranch? lockBranch,
            global::G.ProtectedBranchAllowForkSyncing? allowForkSyncing)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RequiredStatusChecks = requiredStatusChecks;
            this.RequiredPullRequestReviews = requiredPullRequestReviews;
            this.RequiredSignatures = requiredSignatures;
            this.EnforceAdmins = enforceAdmins;
            this.RequiredLinearHistory = requiredLinearHistory;
            this.AllowForcePushes = allowForcePushes;
            this.AllowDeletions = allowDeletions;
            this.Restrictions = restrictions;
            this.RequiredConversationResolution = requiredConversationResolution;
            this.BlockCreations = blockCreations;
            this.LockBranch = lockBranch;
            this.AllowForkSyncing = allowForkSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranch" /> class.
        /// </summary>
        public ProtectedBranch()
        {
        }
    }
}