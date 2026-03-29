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
        [global::System.Text.Json.Serialization.JsonPropertyName("roleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// The type of the object to which the privilege belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectType { get; set; }

        /// <summary>
        /// The name of the object to which the role is granted the specified privilege.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectName { get; set; }

        /// <summary>
        /// The privilege that is granted to the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privilege")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Privilege { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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