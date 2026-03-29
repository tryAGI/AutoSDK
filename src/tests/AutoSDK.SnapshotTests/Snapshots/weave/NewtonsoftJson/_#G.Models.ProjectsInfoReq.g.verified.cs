//HintName: G.Models.ProjectsInfoReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsInfoReq
    {
        /// <summary>
        /// External project IDs in 'entity/project' format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ProjectIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsInfoReq" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// External project IDs in 'entity/project' format.
        /// </param>
        public ProjectsInfoReq(
            global::System.Collections.Generic.IList<string> projectIds)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsInfoReq" /> class.
        /// </summary>
        public ProjectsInfoReq()
        {
        }
    }
}