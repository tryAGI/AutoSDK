//HintName: G.Models.ProjectGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectGroupRequest
    {
        /// <summary>
        /// Group name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Group { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// Project role (Inherit, Annotator, Reviewer)<br/>
        /// * `Inherit` - Inherit<br/>
        /// * `Annotator` - Annotator<br/>
        /// * `Reviewer` - Reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectGroupRoleEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectGroupRoleEnum Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroupRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectGroupRequest(
            string group,
            int projectId,
            global::G.ProjectGroupRoleEnum role)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.ProjectId = projectId;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroupRequest" /> class.
        /// </summary>
        public ProjectGroupRequest()
        {
        }
    }
}