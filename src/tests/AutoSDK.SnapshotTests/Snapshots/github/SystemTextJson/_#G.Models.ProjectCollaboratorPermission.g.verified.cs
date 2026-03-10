//HintName: G.Models.ProjectCollaboratorPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project Collaborator Permission
    /// </summary>
    public sealed partial class ProjectCollaboratorPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCollaboratorPermission" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCollaboratorPermission(
            string permission,
            global::G.NullableSimpleUser? user)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCollaboratorPermission" /> class.
        /// </summary>
        public ProjectCollaboratorPermission()
        {
        }
    }
}