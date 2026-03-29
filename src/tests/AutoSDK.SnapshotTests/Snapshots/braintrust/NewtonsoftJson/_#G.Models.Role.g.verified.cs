//HintName: G.Models.Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A role is a collection of permissions which can be granted as part of an ACL<br/>
    /// Roles can consist of individual permissions, as well as a set of roles they inherit from
    /// </summary>
    public sealed partial class Role
    {
        /// <summary>
        /// Unique identifier for the role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique id for the organization that the role belongs under<br/>
        /// A null org_id indicates a system role, which may be assigned to anybody and inherited by any other role, but cannot be edited.<br/>
        /// It is forbidden to change the org after creating a role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// Identifies the user who created the role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of role creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of role deletion, or null if the role is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// (permission, restrict_object_type) tuples which belong to this role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_permissions")]
        public global::System.Collections.Generic.IList<global::G.RoleMemberPermission>? MemberPermissions { get; set; }

        /// <summary>
        /// Ids of the roles this role inherits from<br/>
        /// An inheriting role has all the permissions contained in its member roles, as well as all of their inherited permissions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_roles")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the role
        /// </param>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="orgId">
        /// Unique id for the organization that the role belongs under<br/>
        /// A null org_id indicates a system role, which may be assigned to anybody and inherited by any other role, but cannot be edited.<br/>
        /// It is forbidden to change the org after creating a role
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the role
        /// </param>
        /// <param name="created">
        /// Date of role creation
        /// </param>
        /// <param name="description">
        /// Textual description of the role
        /// </param>
        /// <param name="deletedAt">
        /// Date of role deletion, or null if the role is still active
        /// </param>
        /// <param name="memberPermissions">
        /// (permission, restrict_object_type) tuples which belong to this role
        /// </param>
        /// <param name="memberRoles">
        /// Ids of the roles this role inherits from<br/>
        /// An inheriting role has all the permissions contained in its member roles, as well as all of their inherited permissions
        /// </param>
        public Role(
            global::System.Guid id,
            string name,
            global::System.Guid? orgId,
            global::System.Guid? userId,
            global::System.DateTime? created,
            string? description,
            global::System.DateTime? deletedAt,
            global::System.Collections.Generic.IList<global::G.RoleMemberPermission>? memberPermissions,
            global::System.Collections.Generic.IList<global::System.Guid>? memberRoles)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DeletedAt = deletedAt;
            this.MemberPermissions = memberPermissions;
            this.MemberRoles = memberRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        public Role()
        {
        }
    }
}