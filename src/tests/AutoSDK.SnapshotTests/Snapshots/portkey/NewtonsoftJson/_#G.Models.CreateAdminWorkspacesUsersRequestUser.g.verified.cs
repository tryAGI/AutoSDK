//HintName: G.Models.CreateAdminWorkspacesUsersRequestUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminWorkspacesUsersRequestUser
    {
        /// <summary>
        /// Example: 25afb7bd-f98a-11ee-85fe-0e27d7367987
        /// </summary>
        /// <example>25afb7bd-f98a-11ee-85fe-0e27d7367987</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: member
        /// </summary>
        /// <example>member</example>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.CreateAdminWorkspacesUsersRequestUserRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesUsersRequestUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 25afb7bd-f98a-11ee-85fe-0e27d7367987
        /// </param>
        /// <param name="role">
        /// Example: member
        /// </param>
        public CreateAdminWorkspacesUsersRequestUser(
            global::System.Guid? id,
            global::G.CreateAdminWorkspacesUsersRequestUserRole? role)
        {
            this.Id = id;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesUsersRequestUser" /> class.
        /// </summary>
        public CreateAdminWorkspacesUsersRequestUser()
        {
        }
    }
}