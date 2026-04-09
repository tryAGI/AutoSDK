//HintName: G.Models.ProjectGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectGroup
    {
        /// <summary>
        /// Group name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group", Required = global::Newtonsoft.Json.Required.Always)]
        public string Group { get; set; } = default!;

        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectId { get; set; } = default!;

        /// <summary>
        /// Project role (Inherit, Annotator, Reviewer)<br/>
        /// * `Inherit` - Inherit<br/>
        /// * `Annotator` - Annotator<br/>
        /// * `Reviewer` - Reviewer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectGroupRoleEnumJsonConverter))]
        public global::G.ProjectGroupRoleEnum Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        /// <param name="group">
        /// Group name
        /// </param>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="role">
        /// Project role (Inherit, Annotator, Reviewer)<br/>
        /// * `Inherit` - Inherit<br/>
        /// * `Annotator` - Annotator<br/>
        /// * `Reviewer` - Reviewer
        /// </param>
        public ProjectGroup(
            string group,
            int projectId,
            global::G.ProjectGroupRoleEnum role)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.ProjectId = projectId;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        public ProjectGroup()
        {
        }
    }
}