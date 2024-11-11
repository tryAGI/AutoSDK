//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [check_suite](https://docs.github.com/rest/checks/suites#get-a-check-suite).
    /// </summary>
    public sealed partial class WebhookCheckSuiteCompletedCheckSuite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? After { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteApp App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Before { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_runs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckRunsUrl { get; set; }

        /// <summary>
        /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The head branch name the changes are on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HeadBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommit HeadCommit { get; set; }

        /// <summary>
        /// The SHA of the head commit that is being checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_check_runs_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestCheckRunsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// An array of pull requests that match this check suite. A pull request matches a check suite if they have the same `head_sha` and `head_branch`. When the check suite's `head_branch` is in a forked repository it will be `null` and the `pull_requests` array will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteCompletedCheckSuitePullRequest> PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        public bool? Rerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs_rerequestable")]
        public bool? RunsRerequestable { get; set; }

        /// <summary>
        /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URL that points to the check suite API resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuite" /> class.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="before"></param>
        /// <param name="checkRunsUrl"></param>
        /// <param name="conclusion">
        /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has `completed`.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCheckSuiteCompletedCheckSuite(
            string? after,
            global::G.WebhookCheckSuiteCompletedCheckSuiteApp app,
            string? before,
            string checkRunsUrl,
            global::G.WebhookCheckSuiteCompletedCheckSuiteConclusion? conclusion,
            global::System.DateTime createdAt,
            string? headBranch,
            global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommit headCommit,
            string headSha,
            int id,
            int latestCheckRunsCount,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteCompletedCheckSuitePullRequest> pullRequests,
            global::G.WebhookCheckSuiteCompletedCheckSuiteStatus? status,
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuite" /> class.
        /// </summary>
        public WebhookCheckSuiteCompletedCheckSuite()
        {
        }
    }
}