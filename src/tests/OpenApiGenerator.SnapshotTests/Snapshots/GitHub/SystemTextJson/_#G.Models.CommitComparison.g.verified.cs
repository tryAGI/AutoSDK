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
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PermalinkUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required Commit BaseCommit { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required Commit MergeBaseCommit { get; set; }

        /// <summary>
        /// <br/>Example: ahead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// <br/>Example: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ahead_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AheadBy { get; set; }

        /// <summary>
        /// <br/>Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behind_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BehindBy { get; set; }

        /// <summary>
        /// <br/>Example: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCommits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<Commit> Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}