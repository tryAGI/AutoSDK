﻿//HintName: G.Models.ReposUpdateBranchProtectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateBranchProtectionRequest
    {
        /// <summary>
        /// Require status checks to pass before merging. Set to `null` to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecks? RequiredStatusChecks { get; set; }

        /// <summary>
        /// Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_admins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? EnforceAdmins { get; set; }

        /// <summary>
        /// Require at least one approving review on a pull request, before merging. Set to `null` to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_pull_request_reviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateBranchProtectionRequestRestrictions? Restrictions { get; set; }

        /// <summary>
        /// Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see "[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)" in the GitHub Help documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_linear_history")]
        public bool? RequiredLinearHistory { get; set; }

        /// <summary>
        /// Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_force_pushes")]
        public bool? AllowForcePushes { get; set; }

        /// <summary>
        /// Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_deletions")]
        public bool? AllowDeletions { get; set; }

        /// <summary>
        /// If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_creations")]
        public bool? BlockCreations { get; set; }

        /// <summary>
        /// Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_conversation_resolution")]
        public bool? RequiredConversationResolution { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch. Default: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch")]
        public bool? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing. Default: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fork_syncing")]
        public bool? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequest" /> class.
        /// </summary>
        /// <param name="requiredStatusChecks">
        /// Require status checks to pass before merging. Set to `null` to disable.
        /// </param>
        /// <param name="enforceAdmins">
        /// Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.
        /// </param>
        /// <param name="requiredPullRequestReviews">
        /// Require at least one approving review on a pull request, before merging. Set to `null` to disable.
        /// </param>
        /// <param name="restrictions">
        /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
        /// </param>
        /// <param name="requiredLinearHistory">
        /// Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see "[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)" in the GitHub Help documentation.
        /// </param>
        /// <param name="allowForcePushes">
        /// Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation."
        /// </param>
        /// <param name="allowDeletions">
        /// Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation.
        /// </param>
        /// <param name="blockCreations">
        /// If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.
        /// </param>
        /// <param name="requiredConversationResolution">
        /// Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.
        /// </param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateBranchProtectionRequest(
            global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecks? requiredStatusChecks,
            bool? enforceAdmins,
            global::G.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? requiredPullRequestReviews,
            global::G.ReposUpdateBranchProtectionRequestRestrictions? restrictions,
            bool? requiredLinearHistory,
            bool? allowForcePushes,
            bool? allowDeletions,
            bool? blockCreations,
            bool? requiredConversationResolution,
            bool? lockBranch,
            bool? allowForkSyncing)
        {
            this.RequiredStatusChecks = requiredStatusChecks ?? throw new global::System.ArgumentNullException(nameof(requiredStatusChecks));
            this.EnforceAdmins = enforceAdmins;
            this.RequiredPullRequestReviews = requiredPullRequestReviews ?? throw new global::System.ArgumentNullException(nameof(requiredPullRequestReviews));
            this.Restrictions = restrictions ?? throw new global::System.ArgumentNullException(nameof(restrictions));
            this.RequiredLinearHistory = requiredLinearHistory;
            this.AllowForcePushes = allowForcePushes;
            this.AllowDeletions = allowDeletions;
            this.BlockCreations = blockCreations;
            this.RequiredConversationResolution = requiredConversationResolution;
            this.LockBranch = lockBranch;
            this.AllowForkSyncing = allowForkSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequest" /> class.
        /// </summary>
        public ReposUpdateBranchProtectionRequest()
        {
        }
    }
}