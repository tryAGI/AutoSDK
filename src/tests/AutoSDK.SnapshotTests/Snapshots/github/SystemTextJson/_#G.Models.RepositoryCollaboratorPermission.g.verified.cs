//HintName: G.Models.RepositoryCollaboratorPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository Collaborator Permission
    /// </summary>
    public sealed partial class RepositoryCollaboratorPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Collaborator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableCollaborator? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCollaboratorPermission" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="roleName">
        /// Example: admin
        /// </param>
        /// <param name="user">
        /// Collaborator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryCollaboratorPermission(
            string permission,
            string roleName,
            global::G.NullableCollaborator? user)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCollaboratorPermission" /> class.
        /// </summary>
        public RepositoryCollaboratorPermission()
        {
        }
    }
}