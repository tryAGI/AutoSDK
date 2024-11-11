//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunPullRequestHead.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentCreatedWorkflowRunPullRequestHead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentCreatedWorkflowRunPullRequestHeadRepo Repo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedWorkflowRunPullRequestHead" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        public WebhookDeploymentCreatedWorkflowRunPullRequestHead(
            string @ref,
            global::G.WebhookDeploymentCreatedWorkflowRunPullRequestHeadRepo repo,
            string sha)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedWorkflowRunPullRequestHead" /> class.
        /// </summary>
        public WebhookDeploymentCreatedWorkflowRunPullRequestHead()
        {
        }
    }
}