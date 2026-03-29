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
        [global::Newtonsoft.Json.JsonProperty("projects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProjectsListProjectsResponseProject> Projects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasNextPage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsListProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="hasNextPage"></param>
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