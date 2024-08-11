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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: master
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HeadBranch { get; set; }

        /// <summary>
        /// The SHA of the head commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.<br/>
        /// Example: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CheckSuiteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckSuiteStatus? Status { get; set; }

        /// <summary>
        /// Example: neutral
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CheckSuiteConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckSuiteConclusion? Conclusion { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Url { get; set; }

        /// <summary>
        /// Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Before { get; set; }

        /// <summary>
        /// Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? After { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? PullRequests { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableIntegration? App { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleCommit HeadCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_check_runs_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestCheckRunsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_runs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckRunsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        public bool Rerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs_rerequestable")]
        public bool RunsRerequestable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}