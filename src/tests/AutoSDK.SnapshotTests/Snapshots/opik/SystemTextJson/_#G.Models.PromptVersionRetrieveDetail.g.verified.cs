//HintName: G.Models.PromptVersionRetrieveDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionRetrieveDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// If provided, scopes the search to the specified project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionRetrieveDetail" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="projectName">
        /// If provided, scopes the search to the specified project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionRetrieveDetail(
            string name,
            string? commit,
            string? projectName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionRetrieveDetail" /> class.
        /// </summary>
        public PromptVersionRetrieveDetail()
        {
        }
    }
}