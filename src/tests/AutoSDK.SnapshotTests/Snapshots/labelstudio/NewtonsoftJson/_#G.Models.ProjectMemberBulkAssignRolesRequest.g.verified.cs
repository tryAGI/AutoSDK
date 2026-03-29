//HintName: G.Models.ProjectMemberBulkAssignRolesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMemberBulkAssignRolesRequest
    {
        /// <summary>
        /// Role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Role9e7Enum Role { get; set; } = default!;

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberBulkAssignRolesRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// Role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userId">
        /// User ID
        /// </param>
        public ProjectMemberBulkAssignRolesRequest(
            global::G.Role9e7Enum role,
            int userId)
        {
            this.Role = role;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberBulkAssignRolesRequest" /> class.
        /// </summary>
        public ProjectMemberBulkAssignRolesRequest()
        {
        }
    }
}