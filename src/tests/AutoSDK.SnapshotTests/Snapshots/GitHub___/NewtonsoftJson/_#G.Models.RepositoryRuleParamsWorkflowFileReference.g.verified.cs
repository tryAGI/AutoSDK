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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The ref (branch or tag) of the workflow file to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The ID of the repository where the workflow is defined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// The commit SHA of the workflow file to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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