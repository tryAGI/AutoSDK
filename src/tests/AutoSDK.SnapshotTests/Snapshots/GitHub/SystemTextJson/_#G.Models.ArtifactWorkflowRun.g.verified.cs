//HintName: G.Models.ArtifactWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactWorkflowRun
    {
        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_repository_id")]
        public int? HeadRepositoryId { get; set; }

        /// <summary>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactWorkflowRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 10
        /// </param>
        /// <param name="repositoryId">
        /// Example: 42
        /// </param>
        /// <param name="headRepositoryId">
        /// Example: 42
        /// </param>
        /// <param name="headBranch">
        /// Example: main
        /// </param>
        /// <param name="headSha">
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ArtifactWorkflowRun(
            int? id,
            int? repositoryId,
            int? headRepositoryId,
            string? headBranch,
            string? headSha)
        {
            this.Id = id;
            this.RepositoryId = repositoryId;
            this.HeadRepositoryId = headRepositoryId;
            this.HeadBranch = headBranch;
            this.HeadSha = headSha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactWorkflowRun" /> class.
        /// </summary>
        public ArtifactWorkflowRun()
        {
        }
    }
}