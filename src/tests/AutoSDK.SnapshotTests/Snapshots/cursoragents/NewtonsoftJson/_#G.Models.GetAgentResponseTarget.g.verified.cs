//HintName: G.Models.GetAgentResponseTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseTarget
    {
        /// <summary>
        /// The Git branch name where the agent is working<br/>
        /// Example: cursor/add-readme-1234
        /// </summary>
        /// <example>cursor/add-readme-1234</example>
        [global::Newtonsoft.Json.JsonProperty("branchName")]
        public string? BranchName { get; set; }

        /// <summary>
        /// URL to view the agent in Cursor Web<br/>
        /// Example: https://cursor.com/agents?id=bc_abc123
        /// </summary>
        /// <example>https://cursor.com/agents?id=bc_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// URL to view the pull request in GitHub, if any<br/>
        /// Example: https://github.com/your-org/your-repo/pull/1234
        /// </summary>
        /// <example>https://github.com/your-org/your-repo/pull/1234</example>
        [global::Newtonsoft.Json.JsonProperty("prUrl")]
        public string? PrUrl { get; set; }

        /// <summary>
        /// Whether a pull request will be automatically created<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("autoCreatePr")]
        public bool? AutoCreatePr { get; set; }

        /// <summary>
        /// Whether the pull request will be opened as the Cursor GitHub App<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("openAsCursorGithubApp")]
        public bool? OpenAsCursorGithubApp { get; set; }

        /// <summary>
        /// Whether to skip adding the user as a reviewer to the pull request<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("skipReviewerRequest")]
        public bool? SkipReviewerRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseTarget" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to view the agent in Cursor Web<br/>
        /// Example: https://cursor.com/agents?id=bc_abc123
        /// </param>
        /// <param name="branchName">
        /// The Git branch name where the agent is working<br/>
        /// Example: cursor/add-readme-1234
        /// </param>
        /// <param name="prUrl">
        /// URL to view the pull request in GitHub, if any<br/>
        /// Example: https://github.com/your-org/your-repo/pull/1234
        /// </param>
        /// <param name="autoCreatePr">
        /// Whether a pull request will be automatically created<br/>
        /// Example: false
        /// </param>
        /// <param name="openAsCursorGithubApp">
        /// Whether the pull request will be opened as the Cursor GitHub App<br/>
        /// Example: false
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip adding the user as a reviewer to the pull request<br/>
        /// Example: false
        /// </param>
        public GetAgentResponseTarget(
            string url,
            string? branchName,
            string? prUrl,
            bool? autoCreatePr,
            bool? openAsCursorGithubApp,
            bool? skipReviewerRequest)
        {
            this.BranchName = branchName;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PrUrl = prUrl;
            this.AutoCreatePr = autoCreatePr;
            this.OpenAsCursorGithubApp = openAsCursorGithubApp;
            this.SkipReviewerRequest = skipReviewerRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseTarget" /> class.
        /// </summary>
        public GetAgentResponseTarget()
        {
        }
    }
}