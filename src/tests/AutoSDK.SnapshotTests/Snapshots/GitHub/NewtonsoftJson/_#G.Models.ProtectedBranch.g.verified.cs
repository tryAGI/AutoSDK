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
        public global::G.StatusCheckPolicy? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_pull_request_reviews")]
        public global::G.ProtectedBranchRequiredPullRequestReviews? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_signatures")]
        public global::G.ProtectedBranchRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_admins")]
        public global::G.ProtectedBranchEnforceAdmins? EnforceAdmins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_linear_history")]
        public global::G.ProtectedBranchRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes")]
        public global::G.ProtectedBranchAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions")]
        public global::G.ProtectedBranchAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public global::G.BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution")]
        public global::G.ProtectedBranchRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_creations")]
        public global::G.ProtectedBranchBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch")]
        public global::G.ProtectedBranchLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_fork_syncing")]
        public global::G.ProtectedBranchAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.ProtectedBranch? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ProtectedBranch>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranch?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranch?>(serializer.Deserialize<global::G.ProtectedBranch>(jsonReader));
        }

    }
}