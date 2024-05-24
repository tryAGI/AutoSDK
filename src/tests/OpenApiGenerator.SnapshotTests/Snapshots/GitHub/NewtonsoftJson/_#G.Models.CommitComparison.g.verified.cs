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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permalink_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PermalinkUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PatchUrl { get; set; } = default!;

        /// <summary>
        /// Commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public Commit BaseCommit { get; set; } = default!;

        /// <summary>
        /// Commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_base_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public Commit MergeBaseCommit { get; set; } = default!;

        /// <summary>
        /// <br/>Example: ahead
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public CommitComparisonStatus Status { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ahead_by", Required = global::Newtonsoft.Json.Required.Always)]
        public int AheadBy { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("behind_by", Required = global::Newtonsoft.Json.Required.Always)]
        public int BehindBy { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_commits", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCommits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<Commit> Commits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}