//HintName: G.Models.CheckRunWithSimpleCheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A check performed on the code of a given code change
    /// </summary>
    public sealed partial class CheckRunWithSimpleCheckSuite
    {
        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableIntegration? App { get; set; }

        /// <summary>
        /// A suite of checks performed on the code of a given code change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleCheckSuite CheckSuite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Example: neutral
        /// </summary>
        /// <example>neutral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckRunWithSimpleCheckSuiteConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunWithSimpleCheckSuiteConclusion? Conclusion { get; set; }

        /// <summary>
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::G.DeploymentSimple? Deployment { get; set; }

        /// <summary>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DetailsUrl { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// The SHA of the commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        /// <example>https://github.com/github/hello-world/runs/4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The id of the check.<br/>
        /// Example: 21
        /// </summary>
        /// <example>21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the check.<br/>
        /// Example: test-coverage
        /// </summary>
        /// <example>test-coverage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        /// <example>MDg6Q2hlY2tSdW40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunWithSimpleCheckSuiteOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PullRequestMinimal> PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The phase of the lifecycle that the check is currently in.<br/>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckRunWithSimpleCheckSuiteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunWithSimpleCheckSuiteStatus Status { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/check-runs/4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunWithSimpleCheckSuite" /> class.
        /// </summary>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="checkSuite">
        /// A suite of checks performed on the code of a given code change
        /// </param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion">
        /// Example: neutral
        /// </param>
        /// <param name="deployment">
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </param>
        /// <param name="detailsUrl">
        /// Example: https://example.com
        /// </param>
        /// <param name="externalId">
        /// Example: 42
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/runs/4
        /// </param>
        /// <param name="id">
        /// The id of the check.<br/>
        /// Example: 21
        /// </param>
        /// <param name="name">
        /// The name of the check.<br/>
        /// Example: test-coverage
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6Q2hlY2tSdW40
        /// </param>
        /// <param name="output"></param>
        /// <param name="pullRequests"></param>
        /// <param name="startedAt"></param>
        /// <param name="status">
        /// The phase of the lifecycle that the check is currently in.<br/>
        /// Example: queued
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckRunWithSimpleCheckSuite(
            global::G.NullableIntegration? app,
            global::G.SimpleCheckSuite checkSuite,
            global::System.DateTime? completedAt,
            global::G.CheckRunWithSimpleCheckSuiteConclusion? conclusion,
            string detailsUrl,
            string externalId,
            string headSha,
            string htmlUrl,
            int id,
            string name,
            string nodeId,
            global::G.CheckRunWithSimpleCheckSuiteOutput output,
            global::System.Collections.Generic.IList<global::G.PullRequestMinimal> pullRequests,
            global::System.DateTime startedAt,
            global::G.CheckRunWithSimpleCheckSuiteStatus status,
            string url,
            global::G.DeploymentSimple? deployment)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.CheckSuite = checkSuite ?? throw new global::System.ArgumentNullException(nameof(checkSuite));
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.DetailsUrl = detailsUrl ?? throw new global::System.ArgumentNullException(nameof(detailsUrl));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.StartedAt = startedAt;
            this.Status = status;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunWithSimpleCheckSuite" /> class.
        /// </summary>
        public CheckRunWithSimpleCheckSuite()
        {
        }
    }
}