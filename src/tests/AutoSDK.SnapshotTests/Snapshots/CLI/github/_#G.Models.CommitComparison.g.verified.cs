//HintName: G.Models.CommitComparison.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Comparison
    /// </summary>
    public sealed partial class CommitComparison
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/compare/master...topic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PermalinkUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic.diff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic.patch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit BaseCommit { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit MergeBaseCommit { get; set; }

        /// <summary>
        /// Example: ahead
        /// </summary>
        /// <example>ahead</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CommitComparisonStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommitComparisonStatus Status { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ahead_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AheadBy { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("behind_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BehindBy { get; set; }

        /// <summary>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCommits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Commit> Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::G.DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitComparison" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </param>
        /// <param name="permalinkUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </param>
        /// <param name="diffUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </param>
        /// <param name="patchUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </param>
        /// <param name="baseCommit">
        /// Commit
        /// </param>
        /// <param name="mergeBaseCommit">
        /// Commit
        /// </param>
        /// <param name="status">
        /// Example: ahead
        /// </param>
        /// <param name="aheadBy">
        /// Example: 4
        /// </param>
        /// <param name="behindBy">
        /// Example: 5
        /// </param>
        /// <param name="totalCommits">
        /// Example: 6
        /// </param>
        /// <param name="commits"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitComparison(
            string url,
            string htmlUrl,
            string permalinkUrl,
            string diffUrl,
            string patchUrl,
            global::G.Commit baseCommit,
            global::G.Commit mergeBaseCommit,
            global::G.CommitComparisonStatus status,
            int aheadBy,
            int behindBy,
            int totalCommits,
            global::System.Collections.Generic.IList<global::G.Commit> commits,
            global::System.Collections.Generic.IList<global::G.DiffEntry>? files)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PermalinkUrl = permalinkUrl ?? throw new global::System.ArgumentNullException(nameof(permalinkUrl));
            this.DiffUrl = diffUrl ?? throw new global::System.ArgumentNullException(nameof(diffUrl));
            this.PatchUrl = patchUrl ?? throw new global::System.ArgumentNullException(nameof(patchUrl));
            this.BaseCommit = baseCommit ?? throw new global::System.ArgumentNullException(nameof(baseCommit));
            this.MergeBaseCommit = mergeBaseCommit ?? throw new global::System.ArgumentNullException(nameof(mergeBaseCommit));
            this.Status = status;
            this.AheadBy = aheadBy;
            this.BehindBy = behindBy;
            this.TotalCommits = totalCommits;
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitComparison" /> class.
        /// </summary>
        public CommitComparison()
        {
        }
    }
}