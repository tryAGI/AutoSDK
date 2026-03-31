//HintName: G.Models.PatchRoleAddMemberPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchRoleAddMemberPermission
    {
        /// <summary>
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Permission Permission { get; set; }

        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        public global::G.AclObjectType? RestrictObjectType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoleAddMemberPermission" /> class.
        /// </summary>
        /// <param name="permission">
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </param>
        /// <param name="restrictObjectType">
        /// The object type that the ACL applies to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRoleAddMemberPermission(
            global::G.Permission permission,
            global::G.AclObjectType? restrictObjectType)
        {
            this.Permission = permission;
            this.RestrictObjectType = restrictObjectType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoleAddMemberPermission" /> class.
        /// </summary>
        public PatchRoleAddMemberPermission()
        {
        }
    }
}