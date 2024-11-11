//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [check_suite](https://docs.github.com/rest/checks/suites#get-a-check-suite).
    /// </summary>
    public sealed partial class WebhookCheckSuiteRequestedCheckSuite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after", Required = global::Newtonsoft.Json.Required.Always)]
        public string? After { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteApp App { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Before { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_runs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckRunsUrl { get; set; } = default!;

        /// <summary>
        /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The head branch name the changes are on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HeadBranch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteHeadCommit HeadCommit { get; set; } = default!;

        /// <summary>
        /// The SHA of the head commit that is being checked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_check_runs_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int LatestCheckRunsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// An array of pull requests that match this check suite. A pull request matches a check suite if they have the same `head_sha` and `head_branch`. When the check suite's `head_branch` is in a forked repository it will be `null` and the `pull_requests` array will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteRequestedCheckSuitePullRequest> PullRequests { get; set; } = default!;

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
        /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteStatus? Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL that points to the check suite API resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuite" /> class.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="before"></param>
        /// <param name="checkRunsUrl"></param>
        /// <param name="conclusion">
        /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has completed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="headBranch">
        /// The head branch name the changes are on.
        /// </param>
        /// <param name="headCommit"></param>
        /// <param name="headSha">
        /// The SHA of the head commit that is being checked.
        /// </param>
        /// <param name="id"></param>
        /// <param name="latestCheckRunsCount"></param>
        /// <param name="nodeId"></param>
        /// <param name="pullRequests">
        /// An array of pull requests that match this check suite. A pull request matches a check suite if they have the same `head_sha` and `head_branch`. When the check suite's `head_branch` is in a forked repository it will be `null` and the `pull_requests` array will be empty.
        /// </param>
        /// <param name="rerequestable"></param>
        /// <param name="runsRerequestable"></param>
        /// <param name="status">
        /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL that points to the check suite API resource.
        /// </param>
        public WebhookCheckSuiteRequestedCheckSuite(
            string? after,
            global::G.WebhookCheckSuiteRequestedCheckSuiteApp app,
            string? before,
            string checkRunsUrl,
            global::G.WebhookCheckSuiteRequestedCheckSuiteConclusion? conclusion,
            global::System.DateTime createdAt,
            string? headBranch,
            global::G.WebhookCheckSuiteRequestedCheckSuiteHeadCommit headCommit,
            string headSha,
            int id,
            int latestCheckRunsCount,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteRequestedCheckSuitePullRequest> pullRequests,
            global::G.WebhookCheckSuiteRequestedCheckSuiteStatus? status,
            global::System.DateTime updatedAt,
            string url,
            bool? rerequestable,
            bool? runsRerequestable)
        {
            this.After = after ?? throw new global::System.ArgumentNullException(nameof(after));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
            this.CheckRunsUrl = checkRunsUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunsUrl));
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Id = id;
            this.LatestCheckRunsCount = latestCheckRunsCount;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Rerequestable = rerequestable;
            this.RunsRerequestable = runsRerequestable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuite" /> class.
        /// </summary>
        public WebhookCheckSuiteRequestedCheckSuite()
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
        public static global::G.WebhookCheckSuiteRequestedCheckSuite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookCheckSuiteRequestedCheckSuite>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookCheckSuiteRequestedCheckSuite?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookCheckSuiteRequestedCheckSuite?>(serializer.Deserialize<global::G.WebhookCheckSuiteRequestedCheckSuite>(jsonReader));
        }

    }
}