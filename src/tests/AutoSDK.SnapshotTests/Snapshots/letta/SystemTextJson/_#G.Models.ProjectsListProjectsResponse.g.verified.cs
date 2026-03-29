//HintName: G.Models.ProjectsListProjectsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsListProjectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProjectsListProjectsResponseProject> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsListProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsListProjectsResponse(
            global::System.Collections.Generic.IList<global::G.ProjectsListProjectsResponseProject> projects,
            bool hasNextPage)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsListProjectsResponse" /> class.
        /// </summary>
        public ProjectsListProjectsResponse()
        {
        }
    }
}