﻿//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunPullRequestBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentCreatedWorkflowRunPullRequestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentCreatedWorkflowRunPullRequestBaseRepo Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedWorkflowRunPullRequestBase" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeploymentCreatedWorkflowRunPullRequestBase(
            string @ref,
            global::G.WebhookDeploymentCreatedWorkflowRunPullRequestBaseRepo repo,
            string sha)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedWorkflowRunPullRequestBase" /> class.
        /// </summary>
        public WebhookDeploymentCreatedWorkflowRunPullRequestBase()
        {
        }
    }
}