//HintName: G.Models.CreateAgentRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequestTarget
    {
        /// <summary>
        /// Whether to automatically create a pull request when the agent completes<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoCreatePr")]
        public bool? AutoCreatePr { get; set; }

        /// <summary>
        /// Whether to open the pull request as the Cursor GitHub App instead of as the user. Only applies if autoCreatePr is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAsCursorGithubApp")]
        public bool? OpenAsCursorGithubApp { get; set; }

        /// <summary>
        /// Whether to skip adding the user as a reviewer to the pull request. Only applies if autoCreatePr is true and the PR is opened as the Cursor GitHub App.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipReviewerRequest")]
        public bool? SkipReviewerRequest { get; set; }

        /// <summary>
        /// Custom branch name for the agent to create<br/>
        /// Example: feature/add-readme
        /// </summary>
        /// <example>feature/add-readme</example>
        [global::Newtonsoft.Json.JsonProperty("branchName")]
        public string? BranchName { get; set; }

        /// <summary>
        /// Whether to create a new branch (true) or use the PR's existing head branch (false). Only applies when source.prUrl is provided.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoBranch")]
        public bool? AutoBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestTarget" /> class.
        /// </summary>
        /// <param name="autoCreatePr">
        /// Whether to automatically create a pull request when the agent completes<br/>
        /// Default Value: false
        /// </param>
        /// <param name="openAsCursorGithubApp">
        /// Whether to open the pull request as the Cursor GitHub App instead of as the user. Only applies if autoCreatePr is true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip adding the user as a reviewer to the pull request. Only applies if autoCreatePr is true and the PR is opened as the Cursor GitHub App.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="branchName">
        /// Custom branch name for the agent to create<br/>
        /// Example: feature/add-readme
        /// </param>
        /// <param name="autoBranch">
        /// Whether to create a new branch (true) or use the PR's existing head branch (false). Only applies when source.prUrl is provided.<br/>
        /// Default Value: true
        /// </param>
        public CreateAgentRequestTarget(
            bool? autoCreatePr,
            bool? openAsCursorGithubApp,
            bool? skipReviewerRequest,
            string? branchName,
            bool? autoBranch)
        {
            this.AutoCreatePr = autoCreatePr;
            this.OpenAsCursorGithubApp = openAsCursorGithubApp;
            this.SkipReviewerRequest = skipReviewerRequest;
            this.BranchName = branchName;
            this.AutoBranch = autoBranch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestTarget" /> class.
        /// </summary>
        public CreateAgentRequestTarget()
        {
        }
    }
}