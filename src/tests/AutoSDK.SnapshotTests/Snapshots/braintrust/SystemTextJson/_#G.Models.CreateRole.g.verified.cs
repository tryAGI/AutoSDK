//HintName: G.Models.CreateRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRole
    {
        /// <summary>
        /// Name of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// (permission, restrict_object_type) tuples which belong to this role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_permissions")]
        public global::System.Collections.Generic.IList<global::G.CreateRoleMemberPermission>? MemberPermissions { get; set; }

        /// <summary>
        /// Ids of the roles this role inherits from<br/>
        /// An inheriting role has all the permissions contained in its member roles, as well as all of their inherited permissions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_roles")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberRoles { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the role belongs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRole" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="description">
        /// Textual description of the role
        /// </param>
        /// <param name="memberPermissions">
        /// (permission, restrict_object_type) tuples which belong to this role
        /// </param>
        /// <param name="memberRoles">
        /// Ids of the roles this role inherits from<br/>
        /// An inheriting role has all the permissions contained in its member roles, as well as all of their inherited permissions
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the role belongs in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRole(
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::G.CreateRoleMemberPermission>? memberPermissions,
            global::System.Collections.Generic.IList<global::System.Guid>? memberRoles,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.MemberPermissions = memberPermissions;
            this.MemberRoles = memberRoles;
            this.OrgName = orgName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRole" /> class.
        /// </summary>
        public CreateRole()
        {
        }
    }
}