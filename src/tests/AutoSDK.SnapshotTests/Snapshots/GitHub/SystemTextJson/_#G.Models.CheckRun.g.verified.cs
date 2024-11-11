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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The SHA of the commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ExternalId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DetailsUrl { get; set; }

        /// <summary>
        /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.<br/>
        /// Example: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunStatus Status { get; set; }

        /// <summary>
        /// Example: neutral
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckRunConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunOutput Output { get; set; }

        /// <summary>
        /// The name of the check.<br/>
        /// Example: test-coverage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckRunCheckSuite? CheckSuite { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableIntegration? App { get; set; }

        /// <summary>
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the check. The returned pull requests do not necessarily indicate pull requests that triggered the check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PullRequestMinimal> PullRequests { get; set; }

        /// <summary>
        /// A deployment created as the result of an Actions check run from a workflow that references an environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::G.DeploymentSimple? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CheckRun? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CheckRun),
                jsonSerializerContext) as global::G.CheckRun;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckRun>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CheckRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CheckRun),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CheckRun;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CheckRun?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}