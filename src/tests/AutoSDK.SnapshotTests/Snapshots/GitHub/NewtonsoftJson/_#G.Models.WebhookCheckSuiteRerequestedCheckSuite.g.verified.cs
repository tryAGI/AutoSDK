//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [check_suite](https://docs.github.com/rest/checks/suites#get-a-check-suite).
    /// </summary>
    public sealed partial class WebhookCheckSuiteRerequestedCheckSuite
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
        public global::G.WebhookCheckSuiteRerequestedCheckSuiteApp App { get; set; } = default!;

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
        public global::G.WebhookCheckSuiteRerequestedCheckSuiteConclusion? Conclusion { get; set; } = default!;

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
        public global::G.WebhookCheckSuiteRerequestedCheckSuiteHeadCommit HeadCommit { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteRerequestedCheckSuitePullRequest> PullRequests { get; set; } = default!;

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
        public global::G.WebhookCheckSuiteRerequestedCheckSuiteStatus? Status { get; set; } = default!;

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
        public static global::G.WebhookCheckSuiteRerequestedCheckSuite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookCheckSuiteRerequestedCheckSuite>(
                json,
                jsonSerializerOptions);
        }

    }
}