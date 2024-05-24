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
        /// <br/>Example: d6fde92930d4715a2b49857d24b940956b26d2d3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after")]
        public string? After { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app")]
        public Integration? App { get; set; }

        /// <summary>
        /// <br/>Example: 146e867f55c26428e5f9fade55a9bbf5e95a7912
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before")]
        public string? Before { get; set; }

        /// <summary>
        /// <br/>Example: neutral
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        public SimpleCheckSuiteConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: master
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// The SHA of the head commit that is being checked.
        /// <br/>Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// <br/>Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests")]
        public global::System.Collections.Generic.IList<PullRequestMinimal>? PullRequests { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public MinimalRepository? Repository { get; set; }

        /// <summary>
        /// <br/>Example: completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public SimpleCheckSuiteStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/github/hello-world/check-suites/5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}