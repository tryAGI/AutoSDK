//HintName: G.Models.ReposUpdateBranchProtectionRequest.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("required_status_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecks? RequiredStatusChecks { get; set; } = default!;

        /// <summary>
        /// Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_admins", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? EnforceAdmins { get; set; } = default!;

        /// <summary>
        /// Require at least one approving review on a pull request, before merging. Set to `null` to disable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_pull_request_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? RequiredPullRequestReviews { get; set; } = default!;

        /// <summary>
        /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposUpdateBranchProtectionRequestRestrictions? Restrictions { get; set; } = default!;

        /// <summary>
        /// Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see "[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)" in the GitHub Help documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_linear_history")]
        public bool? RequiredLinearHistory { get; set; }

        /// <summary>
        /// Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes")]
        public bool? AllowForcePushes { get; set; }

        /// <summary>
        /// Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions")]
        public bool? AllowDeletions { get; set; }

        /// <summary>
        /// If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_creations")]
        public bool? BlockCreations { get; set; }

        /// <summary>
        /// Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution")]
        public bool? RequiredConversationResolution { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch. Default: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch")]
        public bool? LockBranch { get; set; } = false;

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing. Default: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_fork_syncing")]
        public bool? AllowForkSyncing { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposUpdateBranchProtectionRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposUpdateBranchProtectionRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}