//HintName: G.Models.ProjectReferencePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project reference with ID and name<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ProjectReferencePublic
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Project name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReferencePublic" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="projectName">
        /// Project name
        /// </param>
        public ProjectReferencePublic(
            global::System.Guid projectId,
            string projectName)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReferencePublic" /> class.
        /// </summary>
        public ProjectReferencePublic()
        {
        }
    }
}