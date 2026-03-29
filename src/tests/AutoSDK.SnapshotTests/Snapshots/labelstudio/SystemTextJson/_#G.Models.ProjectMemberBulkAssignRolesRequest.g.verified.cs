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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Role9e7EnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Role9e7Enum Role { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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