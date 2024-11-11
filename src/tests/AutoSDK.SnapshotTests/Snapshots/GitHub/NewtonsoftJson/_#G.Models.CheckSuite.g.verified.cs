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
        public global::G.MinimalRepository Repository { get; set; } = default!;

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
        public global::G.SimpleCommit HeadCommit { get; set; } = default!;

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
        public bool? Rerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs_rerequestable")]
        public bool? RunsRerequestable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuite" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 5
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </param>
        /// <param name="headBranch">
        /// Example: master
        /// </param>
        /// <param name="headSha">
        /// The SHA of the head commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="status">
        /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.<br/>
        /// Example: completed
        /// </param>
        /// <param name="conclusion">
        /// Example: neutral
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </param>
        /// <param name="before">
        /// Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </param>
        /// <param name="after">
        /// Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </param>
        /// <param name="pullRequests"></param>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="headCommit">
        /// A commit.
        /// </param>
        /// <param name="latestCheckRunsCount"></param>
        /// <param name="checkRunsUrl"></param>
        /// <param name="rerequestable"></param>
        /// <param name="runsRerequestable"></param>
        public CheckSuite(
            int id,
            string nodeId,
            string? headBranch,
            string headSha,
            global::G.CheckSuiteStatus? status,
            global::G.CheckSuiteConclusion? conclusion,
            string? url,
            string? before,
            string? after,
            global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? pullRequests,
            global::G.NullableIntegration? app,
            global::G.MinimalRepository repository,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.SimpleCommit headCommit,
            int latestCheckRunsCount,
            string checkRunsUrl,
            bool? rerequestable,
            bool? runsRerequestable)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Status = status;
            this.Conclusion = conclusion;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
            this.After = after ?? throw new global::System.ArgumentNullException(nameof(after));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.LatestCheckRunsCount = latestCheckRunsCount;
            this.CheckRunsUrl = checkRunsUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunsUrl));
            this.Rerequestable = rerequestable;
            this.RunsRerequestable = runsRerequestable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuite" /> class.
        /// </summary>
        public CheckSuite()
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
        public static global::G.CheckSuite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheckSuite>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CheckSuite?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CheckSuite?>(serializer.Deserialize<global::G.CheckSuite>(jsonReader));
        }

    }
}