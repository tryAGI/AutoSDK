//HintName: G.Models.SimpleCheckSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A suite of checks performed on the code of a given code change
    /// </summary>
    public sealed partial class SimpleCheckSuite
    {
        /// <summary>
        /// Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </summary>
        /// <example>d6fde92930d4715a2b49857d24b940956b26d2d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::G.Integration? App { get; set; }

        /// <summary>
        /// Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </summary>
        /// <example>146e867f55c26428e5f9fade55a9bbf5e95a7912</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        public string? Before { get; set; }

        /// <summary>
        /// Example: neutral
        /// </summary>
        /// <example>neutral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimpleCheckSuiteConclusionJsonConverter))]
        public global::G.SimpleCheckSuiteConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: master
        /// </summary>
        /// <example>master</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// The SHA of the head commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        /// <example>MDEwOkNoZWNrU3VpdGU1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        public global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? PullRequests { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::G.MinimalRepository? Repository { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimpleCheckSuiteStatusJsonConverter))]
        public global::G.SimpleCheckSuiteStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/check-suites/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCheckSuite" /> class.
        /// </summary>
        /// <param name="after">
        /// Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </param>
        /// <param name="app">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="before">
        /// Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </param>
        /// <param name="conclusion">
        /// Example: neutral
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="headBranch">
        /// Example: master
        /// </param>
        /// <param name="headSha">
        /// The SHA of the head commit that is being checked.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="id">
        /// Example: 5
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </param>
        /// <param name="pullRequests"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SimpleCheckSuite(
            string? after,
            global::G.Integration? app,
            string? before,
            global::G.SimpleCheckSuiteConclusion? conclusion,
            global::System.DateTime? createdAt,
            string? headBranch,
            string? headSha,
            int? id,
            string? nodeId,
            global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? pullRequests,
            global::G.MinimalRepository? repository,
            global::G.SimpleCheckSuiteStatus? status,
            global::System.DateTime? updatedAt,
            string? url)
        {
            this.After = after;
            this.App = app;
            this.Before = before;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.HeadBranch = headBranch;
            this.HeadSha = headSha;
            this.Id = id;
            this.NodeId = nodeId;
            this.PullRequests = pullRequests;
            this.Repository = repository;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCheckSuite" /> class.
        /// </summary>
        public SimpleCheckSuite()
        {
        }
    }
}