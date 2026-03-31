//HintName: G.Models.PatchRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchRole
    {
        /// <summary>
        /// Textual description of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A list of permissions to add to the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_member_permissions")]
        public global::System.Collections.Generic.IList<global::G.PatchRoleAddMemberPermission>? AddMemberPermissions { get; set; }

        /// <summary>
        /// A list of permissions to remove from the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_member_permissions")]
        public global::System.Collections.Generic.IList<global::G.PatchRoleRemoveMemberPermission>? RemoveMemberPermissions { get; set; }

        /// <summary>
        /// A list of role IDs to add to the role's inheriting-from set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_member_roles")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AddMemberRoles { get; set; }

        /// <summary>
        /// A list of role IDs to remove from the role's inheriting-from set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_member_roles")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveMemberRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRole" /> class.
        /// </summary>
        /// <param name="description">
        /// Textual description of the role
        /// </param>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="addMemberPermissions">
        /// A list of permissions to add to the role
        /// </param>
        /// <param name="removeMemberPermissions">
        /// A list of permissions to remove from the role
        /// </param>
        /// <param name="addMemberRoles">
        /// A list of role IDs to add to the role's inheriting-from set
        /// </param>
        /// <param name="removeMemberRoles">
        /// A list of role IDs to remove from the role's inheriting-from set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRole(
            string? description,
            string? name,
            global::System.Collections.Generic.IList<global::G.PatchRoleAddMemberPermission>? addMemberPermissions,
            global::System.Collections.Generic.IList<global::G.PatchRoleRemoveMemberPermission>? removeMemberPermissions,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberRoles,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberRoles)
        {
            this.Description = description;
            this.Name = name;
            this.AddMemberPermissions = addMemberPermissions;
            this.RemoveMemberPermissions = removeMemberPermissions;
            this.AddMemberRoles = addMemberRoles;
            this.RemoveMemberRoles = removeMemberRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRole" /> class.
        /// </summary>
        public PatchRole()
        {
        }
    }
}