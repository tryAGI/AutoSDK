//HintName: G.Models.AutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class AutoMerge
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser EnabledBy { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AutoMergeMergeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AutoMergeMergeMethod MergeMethod { get; set; }

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitTitle { get; set; }

        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMerge" /> class.
        /// </summary>
        /// <param name="enabledBy">
        /// A GitHub user.
        /// </param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        /// <param name="commitTitle">
        /// Title for the merge commit message.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the merge commit.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AutoMerge(
            global::G.SimpleUser enabledBy,
            global::G.AutoMergeMergeMethod mergeMethod,
            string commitTitle,
            string commitMessage)
        {
            this.EnabledBy = enabledBy ?? throw new global::System.ArgumentNullException(nameof(enabledBy));
            this.MergeMethod = mergeMethod;
            this.CommitTitle = commitTitle ?? throw new global::System.ArgumentNullException(nameof(commitTitle));
            this.CommitMessage = commitMessage ?? throw new global::System.ArgumentNullException(nameof(commitMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMerge" /> class.
        /// </summary>
        public AutoMerge()
        {
        }
    }
}