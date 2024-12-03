//HintName: G.Models.RepositoryRuleParamsWorkflowFileReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A workflow that must run for this rule to pass
    /// </summary>
    public sealed partial class RepositoryRuleParamsWorkflowFileReference
    {
        /// <summary>
        /// The path to the workflow file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The ref (branch or tag) of the workflow file to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The ID of the repository where the workflow is defined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// The commit SHA of the workflow file to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsWorkflowFileReference" /> class.
        /// </summary>
        /// <param name="path">
        /// The path to the workflow file
        /// </param>
        /// <param name="ref">
        /// The ref (branch or tag) of the workflow file to use
        /// </param>
        /// <param name="repositoryId">
        /// The ID of the repository where the workflow is defined
        /// </param>
        /// <param name="sha">
        /// The commit SHA of the workflow file to use
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleParamsWorkflowFileReference(
            string path,
            int repositoryId,
            string? @ref,
            string? sha)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RepositoryId = repositoryId;
            this.Ref = @ref;
            this.Sha = sha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsWorkflowFileReference" /> class.
        /// </summary>
        public RepositoryRuleParamsWorkflowFileReference()
        {
        }
    }
}