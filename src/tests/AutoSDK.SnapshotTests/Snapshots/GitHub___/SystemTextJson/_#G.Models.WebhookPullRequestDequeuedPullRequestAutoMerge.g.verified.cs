//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class WebhookPullRequestDequeuedPullRequestAutoMerge
    {
        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitMessage { get; set; }

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestDequeuedPullRequestAutoMergeEnabledBy? EnabledBy { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod MergeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestDequeuedPullRequestAutoMerge" /> class.
        /// </summary>
        /// <param name="commitMessage">
        /// Commit message for the merge commit.
        /// </param>
        /// <param name="commitTitle">
        /// Title for the merge commit message.
        /// </param>
        /// <param name="enabledBy"></param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPullRequestDequeuedPullRequestAutoMerge(
            string? commitMessage,
            string? commitTitle,
            global::G.WebhookPullRequestDequeuedPullRequestAutoMergeEnabledBy? enabledBy,
            global::G.WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod mergeMethod)
        {
            this.CommitMessage = commitMessage ?? throw new global::System.ArgumentNullException(nameof(commitMessage));
            this.CommitTitle = commitTitle ?? throw new global::System.ArgumentNullException(nameof(commitTitle));
            this.EnabledBy = enabledBy ?? throw new global::System.ArgumentNullException(nameof(enabledBy));
            this.MergeMethod = mergeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestDequeuedPullRequestAutoMerge" /> class.
        /// </summary>
        public WebhookPullRequestDequeuedPullRequestAutoMerge()
        {
        }
    }
}