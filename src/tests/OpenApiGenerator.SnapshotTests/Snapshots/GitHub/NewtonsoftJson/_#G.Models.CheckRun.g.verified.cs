//HintName: G.Models.CheckRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A check performed on the code of a given code change
    /// </summary>
    public sealed partial class CheckRun
    {
        /// <summary>
        /// The id of the check.
        /// <br/>Example: 21
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit that is being checked.
        /// <br/>Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDg6Q2hlY2tSdW40
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ExternalId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DetailsUrl { get; set; } = default!;

        /// <summary>
        /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.
        /// <br/>Example: queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public CheckRunStatus Status { get; set; } = default!;

        /// <summary>
        /// <br/>Example: neutral
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public CheckRunConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? StartedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CompletedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public CheckRunOutput Output { get; set; } = default!;

        /// <summary>
        /// The name of the check.
        /// <br/>Example: test-coverage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suite", Required = global::Newtonsoft.Json.Required.Always)]
        public CheckRunCheckSuite? CheckSuite { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableIntegration? App { get; set; } = default!;

        /// <summary>
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the check. The returned pull requests do not necessarily indicate pull requests that triggered the check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<PullRequestMinimal> PullRequests { get; set; } = default!;

        /// <summary>
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment")]
        public DeploymentSimple? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}