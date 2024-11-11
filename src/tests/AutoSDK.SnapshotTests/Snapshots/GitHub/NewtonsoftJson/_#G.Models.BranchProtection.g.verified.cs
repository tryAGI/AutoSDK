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
        public bool? Enabled { get; set; }

        /// <summary>
        /// Protected Branch Required Status Check
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks")]
        public global::G.ProtectedBranchRequiredStatusCheck? RequiredStatusChecks { get; set; }

        /// <summary>
        /// Protected Branch Admin Enforced
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforce_admins")]
        public global::G.ProtectedBranchAdminEnforced? EnforceAdmins { get; set; }

        /// <summary>
        /// Protected Branch Pull Request Review
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_pull_request_reviews")]
        public global::G.ProtectedBranchPullRequestReview? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public global::G.BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_linear_history")]
        public global::G.BranchProtectionRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_force_pushes")]
        public global::G.BranchProtectionAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_deletions")]
        public global::G.BranchProtectionAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_creations")]
        public global::G.BranchProtectionBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_conversation_resolution")]
        public global::G.BranchProtectionRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// Example: "branch/with/protection"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_signatures")]
        public global::G.BranchProtectionRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_branch")]
        public global::G.BranchProtectionLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_fork_syncing")]
        public global::G.BranchProtectionAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="enabled"></param>
        /// <param name="requiredStatusChecks">
        /// Protected Branch Required Status Check
        /// </param>
        /// <param name="enforceAdmins">
        /// Protected Branch Admin Enforced
        /// </param>
        /// <param name="requiredPullRequestReviews">
        /// Protected Branch Pull Request Review
        /// </param>
        /// <param name="restrictions">
        /// Branch Restriction Policy
        /// </param>
        /// <param name="requiredLinearHistory"></param>
        /// <param name="allowForcePushes"></param>
        /// <param name="allowDeletions"></param>
        /// <param name="blockCreations"></param>
        /// <param name="requiredConversationResolution"></param>
        /// <param name="name">
        /// Example: "branch/with/protection"
        /// </param>
        /// <param name="protectionUrl">
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </param>
        /// <param name="requiredSignatures"></param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </param>
        public BranchProtection(
            string? url,
            bool? enabled,
            global::G.ProtectedBranchRequiredStatusCheck? requiredStatusChecks,
            global::G.ProtectedBranchAdminEnforced? enforceAdmins,
            global::G.ProtectedBranchPullRequestReview? requiredPullRequestReviews,
            global::G.BranchRestrictionPolicy? restrictions,
            global::G.BranchProtectionRequiredLinearHistory? requiredLinearHistory,
            global::G.BranchProtectionAllowForcePushes? allowForcePushes,
            global::G.BranchProtectionAllowDeletions? allowDeletions,
            global::G.BranchProtectionBlockCreations? blockCreations,
            global::G.BranchProtectionRequiredConversationResolution? requiredConversationResolution,
            string? name,
            string? protectionUrl,
            global::G.BranchProtectionRequiredSignatures? requiredSignatures,
            global::G.BranchProtectionLockBranch? lockBranch,
            global::G.BranchProtectionAllowForkSyncing? allowForkSyncing)
        {
            this.Url = url;
            this.Enabled = enabled;
            this.RequiredStatusChecks = requiredStatusChecks;
            this.EnforceAdmins = enforceAdmins;
            this.RequiredPullRequestReviews = requiredPullRequestReviews;
            this.Restrictions = restrictions;
            this.RequiredLinearHistory = requiredLinearHistory;
            this.AllowForcePushes = allowForcePushes;
            this.AllowDeletions = allowDeletions;
            this.BlockCreations = blockCreations;
            this.RequiredConversationResolution = requiredConversationResolution;
            this.Name = name;
            this.ProtectionUrl = protectionUrl;
            this.RequiredSignatures = requiredSignatures;
            this.LockBranch = lockBranch;
            this.AllowForkSyncing = allowForkSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        public BranchProtection()
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
        public static global::G.BranchProtection? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BranchProtection>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BranchProtection?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BranchProtection?>(serializer.Deserialize<global::G.BranchProtection>(jsonReader));
        }

    }
}