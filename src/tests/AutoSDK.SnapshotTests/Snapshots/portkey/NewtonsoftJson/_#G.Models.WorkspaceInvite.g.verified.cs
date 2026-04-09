//HintName: G.Models.WorkspaceInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceInvite
    {
        /// <summary>
        /// Workspace Slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkspaceInviteRoleJsonConverter))]
        public global::G.WorkspaceInviteRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInvite" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace Slug
        /// </param>
        /// <param name="role"></param>
        public WorkspaceInvite(
            string id,
            global::G.WorkspaceInviteRole role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInvite" /> class.
        /// </summary>
        public WorkspaceInvite()
        {
        }
    }
}