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
        /// The id of the check.<br/>
        /// Example: 21L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ExternalId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DetailsUrl { get; set; } = default!;

        /// <summary>
        /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.<br/>
        /// Example: queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckRunStatus Status { get; set; } = default!;

        /// <summary>
        /// Example: neutral
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckRunConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CompletedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckRunOutput Output { get; set; } = default!;

        /// <summary>
        /// The name of the check.<br/>
        /// Example: test-coverage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suite", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckRunCheckSuite? CheckSuite { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableIntegration? App { get; set; } = default!;

        /// <summary>
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the check. The returned pull requests do not necessarily indicate pull requests that triggered the check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PullRequestMinimal> PullRequests { get; set; } = default!;

        /// <summary>
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment")]
        public global::G.DeploymentSimple? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the check.<br/>
        /// Example: 21L
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6Q2hlY2tSdW40
        /// </param>
        /// <param name="externalId">
        /// Example: 42
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/runs/4
        /// </param>
        /// <param name="detailsUrl">
        /// Example: https://example.com
        /// </param>
        /// <param name="status">
        /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.<br/>
        /// Example: queued
        /// </param>
        /// <param name="conclusion">
        /// Example: neutral
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="output"></param>
        /// <param name="name">
        /// The name of the check.<br/>
        /// Example: test-coverage
        /// </param>
        /// <param name="checkSuite"></param>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="pullRequests">
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the check. The returned pull requests do not necessarily indicate pull requests that triggered the check.
        /// </param>
        /// <param name="deployment">
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </param>
        public CheckRun(
            long id,
            string headSha,
            string nodeId,
            string? externalId,
            string url,
            string? htmlUrl,
            string? detailsUrl,
            global::G.CheckRunStatus status,
            global::G.CheckRunConclusion? conclusion,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            global::G.CheckRunOutput output,
            string name,
            global::G.CheckRunCheckSuite? checkSuite,
            global::G.NullableIntegration? app,
            global::System.Collections.Generic.IList<global::G.PullRequestMinimal> pullRequests,
            global::G.DeploymentSimple? deployment)
        {
            this.Id = id;
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.DetailsUrl = detailsUrl ?? throw new global::System.ArgumentNullException(nameof(detailsUrl));
            this.Status = status;
            this.Conclusion = conclusion;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CheckSuite = checkSuite ?? throw new global::System.ArgumentNullException(nameof(checkSuite));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRun" /> class.
        /// </summary>
        public CheckRun()
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
        public static global::G.CheckRun? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheckRun>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CheckRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CheckRun?>(serializer.Deserialize<global::G.CheckRun>(jsonReader));
        }

    }
}