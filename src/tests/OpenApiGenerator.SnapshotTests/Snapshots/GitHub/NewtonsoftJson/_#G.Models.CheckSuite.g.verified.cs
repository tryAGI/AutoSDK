//HintName: G.Models.CheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A suite of checks performed on the code of a given code change
    /// </summary>
    public sealed partial class CheckSuite
    {
        /// <summary>
        /// Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: master
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HeadBranch { get; set; } = default!;

        /// <summary>
        /// The SHA of the head commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.<br/>
        /// Example: completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckSuiteStatus? Status { get; set; } = default!;

        /// <summary>
        /// Example: neutral
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckSuiteConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Before { get; set; } = default!;

        /// <summary>
        /// Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after", Required = global::Newtonsoft.Json.Required.Always)]
        public string? After { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? PullRequests { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableIntegration? App { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository? Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// A commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleCommit? HeadCommit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_check_runs_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int LatestCheckRunsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_runs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckRunsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerequestable")]
        public bool Rerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs_rerequestable")]
        public bool RunsRerequestable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}