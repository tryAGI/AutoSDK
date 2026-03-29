//HintName: G.Models.CreateRoleMemberPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRoleMemberPermission
    {
        /// <summary>
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Permission Permission { get; set; } = default!;

        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrict_object_type")]
        public global::G.AclObjectType? RestrictObjectType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoleMemberPermission" /> class.
        /// </summary>
        /// <param name="permission">
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </param>
        /// <param name="restrictObjectType">
        /// The object type that the ACL applies to
        /// </param>
        public CreateRoleMemberPermission(
            global::G.Permission permission,
            global::G.AclObjectType? restrictObjectType)
        {
            this.Permission = permission;
            this.RestrictObjectType = restrictObjectType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoleMemberPermission" /> class.
        /// </summary>
        public CreateRoleMemberPermission()
        {
        }
    }
}