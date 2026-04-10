//HintName: G.Models.AclItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An ACL grants a certain permission or role to a certain user or group on an object.<br/>
    /// ACLs are inherited across the object hierarchy. So for example, if a user has read permissions on a project, they will also have read permissions on any experiment, dataset, etc. created within that project.<br/>
    /// To restrict a grant to a particular sub-object, you may specify `restrict_object_type` in the ACL, as part of a direct permission grant or as part of a role.
    /// </summary>
    public sealed partial class AclItem
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        public global::G.AclObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the object the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public global::System.Guid? GroupId { get; set; }

        /// <summary>
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PermissionJsonConverter))]
        public global::G.Permission? Permission { get; set; }

        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrict_object_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        public global::G.AclObjectType? RestrictObjectType { get; set; }

        /// <summary>
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclItem" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the ACL applies to
        /// </param>
        /// <param name="userId">
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="groupId">
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="permission">
        /// Each permission permits a certain type of operation on an object in the system<br/>
        /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
        /// </param>
        /// <param name="restrictObjectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="roleId">
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
        public AclItem(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            global::System.Guid? userId,
            global::System.Guid? groupId,
            global::G.Permission? permission,
            global::G.AclObjectType? restrictObjectType,
            global::System.Guid? roleId)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.UserId = userId;
            this.GroupId = groupId;
            this.Permission = permission;
            this.RestrictObjectType = restrictObjectType;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AclItem" /> class.
        /// </summary>
        public AclItem()
        {
        }
    }
}