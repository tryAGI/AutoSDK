//HintName: G.Models.CreateVectordbRolesRevokePrivilegeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbRolesRevokePrivilegeRequest
    {
        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roleName", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoleName { get; set; } = default!;

        /// <summary>
        /// The type of the object to which the privilege belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectType { get; set; } = default!;

        /// <summary>
        /// The name of the object to which the role is granted the specified privilege.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectName { get; set; } = default!;

        /// <summary>
        /// The privilege that is granted to the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privilege", Required = global::Newtonsoft.Json.Required.Always)]
        public string Privilege { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbRolesRevokePrivilegeRequest" /> class.
        /// </summary>
        /// <param name="roleName">
        /// The name of the role.
        /// </param>
        /// <param name="objectType">
        /// The type of the object to which the privilege belongs.
        /// </param>
        /// <param name="objectName">
        /// The name of the object to which the role is granted the specified privilege.
        /// </param>
        /// <param name="privilege">
        /// The privilege that is granted to the role.
        /// </param>
        public CreateVectordbRolesRevokePrivilegeRequest(
            string roleName,
            string objectType,
            string objectName,
            string privilege)
        {
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.ObjectType = objectType ?? throw new global::System.ArgumentNullException(nameof(objectType));
            this.ObjectName = objectName ?? throw new global::System.ArgumentNullException(nameof(objectName));
            this.Privilege = privilege ?? throw new global::System.ArgumentNullException(nameof(privilege));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbRolesRevokePrivilegeRequest" /> class.
        /// </summary>
        public CreateVectordbRolesRevokePrivilegeRequest()
        {
        }
    }
}