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
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCollaboratorPermission" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
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