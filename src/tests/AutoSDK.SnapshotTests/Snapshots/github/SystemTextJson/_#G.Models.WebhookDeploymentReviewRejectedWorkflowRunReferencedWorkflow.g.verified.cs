//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow(
            string path,
            string sha,
            string? @ref)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow" /> class.
        /// </summary>
        public WebhookDeploymentReviewRejectedWorkflowRunReferencedWorkflow()
        {
        }
    }
}